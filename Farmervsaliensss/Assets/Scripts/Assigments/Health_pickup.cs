﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_pickup : Pickup
{
    public int healthAmt = 100;

    // Start is called before the first frame update
    void Start()
    {
        print("player health is" + healthAmt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("You Gained " + healthAmt + "Health!");
    }
}
