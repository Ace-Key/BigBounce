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
        KeyCode[] bets = {KeyCode.A, KeyCode.B, KeyCode.C};

        for(int id = 0; id<nextStates.Length; id++)
            for(int a = 0; a<bets.Length; a++)
            {
                {
                    if (Input.GetKeyDown(bets[a]))
                    {
                        currentState = nextStates[id];
                    }
                }
    }
        textComponent.text = currentState.GetStoryState();
    }
}
