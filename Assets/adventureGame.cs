using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] state startingState;

    state state ;
   
	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.getStateStory();
	}
	
	// Update is called once per frame
	void Update () {

        manageState();
	}

    private void manageState()
    {
        var nextState = state.getNextStates();
        for (int permit = 0; permit < nextState.Length; permit++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + permit))
            {
               
                state = nextState[permit];
            }
            textComponent.text = state.getStateStory();

        }
        



    }
}
