using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Rendering;
using UnityEngine;
using UnityEngine.Rendering.UI;


public static class InputManager
{

    private static GameControls _gameControls;
    
    public static void Init(Player myPlayer)
    {
        _gameControls = new GameControls();
        
        _gameControls.Permanent.Enable();

        _gameControls.InGame.Movement.performed += kobe =>
        {
          myPlayer.SetMovementDirection(kobe.ReadValue<Vector3>());  
        };

        _gameControls.InGame.Jump.performed += lebron=>
        {
            Debug.Log("did it work");
        };

        _gameControls.InGame.Crouch.started += durant =>
        {
            Debug.Log("I am crouching");
        };

    }

    public static void SetGameControls()
    {
        _gameControls.InGame.Enable();
        _gameControls.UI.Disable();
    }

    public static void SetUIControls()
    {
        _gameControls.InGame.Disable();
        _gameControls.UI.Enable();
    }



}

