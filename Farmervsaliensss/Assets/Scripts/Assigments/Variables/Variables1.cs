using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables1 : MonoBehaviour
{


   public float amount;
   public float money;
   public float cost;
 


    // Start is called before the first frame update
    void Start()
    {
        Cookies(amount,money, cost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Cookies(float ammount, float money, float cost)
    {
        float total;

        total = money - cost * amount;

        Debug.Log(total);
    }
}
// write 5 different scenarios 