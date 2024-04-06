using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager 
{
    private static Controls _gameControls;
    public static void Init(ZePlayer myPlayer)
    {
        _gameControls = new Controls();

        _gameControls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };
    }
    public static void SetGameControls()
    {
        _gameControls.Game.Enable();
    }
}
