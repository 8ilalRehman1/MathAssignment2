using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Donut : MonoBehaviour
{
    private bool rotate;
    public float rotateSpeed = 5f;
    
    private void Update()
    {
        Rotating();
        
    }
    private void Rotating()
    {
       if (rotate == true)
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
    }
    private void OnCollision(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            rotate = true;
        }
        print("Donut");
    }
}
