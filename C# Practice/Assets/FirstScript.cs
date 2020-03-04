using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start function Getting called");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        print("Inside OnEnable");

    }

    private void OnDisable()
    {
        print("Inside OnDisable");
    }
}
