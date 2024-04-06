using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZePlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 _moveDirection;
    private void Update()
    {
        transform.position += (speed * Time.deltaTime * _moveDirection);
    }
    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }
}
