﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{

  [SerializeField] Text textcompontent;

    // Start is called before the first frame update
    void Start()
    {
        textcompontent.text = ("welcome to the Game");
    }

    // Update is called once per frame
    void Update()
    {


    }
}
