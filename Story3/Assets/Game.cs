using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{

  [SerializeField] Text textcompontent;
  [SerializeField] Text textcompontenttwo;

    // Start is called before the first frame update
    void Start()
    {
        if (textcompontent == false)
        {
            textcompontent.text = ("Game will process");

        }

        else
        {
            textcompontenttwo.text = ("Game start");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
