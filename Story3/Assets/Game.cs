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
    string[] names = { "bob", "johnny", "mark" };





    // Start is called before the first frame update
    void Start()
    {
        state = startingState;

        if (textcompontent == true)
        {
            textcompontent.text = startingState.Storystate();

        }

        if(textcompontenttwo == false)
        {
            foreach (string i in names)
            {
                textcompontenttwo.text = i.ToString();
            }


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


        //if (Input.GetMouseButtonDown(0))
        //{
        //    state = nextstates[0];
        //}


        //else if (Input.GetMouseButtonDown(1))
        //{
        //    state = nextstates[1];
        //}


        //else if (Input.GetMouseButtonDown(2))
        //{
        //    state = nextstates[2];
        //}



        if (Input.GetMouseButtonDown(0))
        {
           
            for (int index = 0; index < nextstates.Length; index++)
            {
                state = nextstates[0];
                state = nextstates[1];
                Debug.Log(state);
                Debug.Log(nextstates.Length);
            }

        }

         textcompontent.text = state.Storystate();
       
    }
}


