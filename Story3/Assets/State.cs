using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]


public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storytext;

    [SerializeField] State[] nextstates;

    public string Storystate()
    {
        return storytext;
    }

    public State[] GetNextStates()
    {

        return nextstates;
    }

}






