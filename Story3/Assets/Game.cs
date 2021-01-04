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

    int[] data = { 1, 2, 3, 4, 5, 6 };

    string[] names = { "bob", "johnny","mark"};
    
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;

        if (textcompontent == true)
        {
            textcompontent.text = startingState.Storystate();

        }

        if(textcompontenttwo)
        {
            foreach (string i in names)
            {
                textcompontenttwo.text = i.ToString();
            }


        }

        print(data);
    }


    // Update is called once per frame
    void Update()
    {
        


    }
}
