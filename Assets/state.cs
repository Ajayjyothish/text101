using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "states")]
public class state : ScriptableObject {

    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] state[] nextStates;

    public string getStateStory()
    {
        return storyText;
    }

    public state[] getNextStates()
    {
        return nextStates;
    }
}   
