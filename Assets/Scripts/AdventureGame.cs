using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] State startingState;
    [SerializeField] Text textComponent;
    
    State currentState;
   // calls the starting options
    void Start()
    {
        currentState = startingState;
        textComponent.text = currentState.GetStoryState();
        
    }
    //calls the methods that manage the game state
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = currentState.GetNextState();

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = nextStates[0]; 
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            currentState = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentState = nextStates[2];
        }
        textComponent.text = currentState.GetStoryState();
    }
}
