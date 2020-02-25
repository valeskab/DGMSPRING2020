﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number Wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your guess higher or lower than..." + guess);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your guess higher or lower than..." + guess);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I'm a genius.");
        }
    }
}