using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour

{

  [SerializeField] Text textcompontent;
  [SerializeField] Text textcompontenttwo;
  [SerializeField] State startingState;

   State state;


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;

        if (textcompontent == true)
        {
            textcompontent.text = startingState.Storystate();

        }



        if(textcompontent == true)
        {
            textcompontenttwo.text = ("GAME HAS STARTED");
        }

        
    }



    // Update is called once per frame
    void Update()
    {

        ManageState();

    }

    private void ManageState()
    {
        var nextstates = state.GetNextStates();


        // for loop to increment state from 1 to 6 when clicked on text game object

        if (Input.GetMouseButtonDown(0))
        {

            for (int index = 0; index < nextstates.Length; index++)
            {
                
                state = nextstates[0];

            }

        }

         textcompontent.text = state.Storystate();
       
    }
}


