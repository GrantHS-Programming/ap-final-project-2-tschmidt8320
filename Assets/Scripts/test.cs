using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            print("up");
        }
        if (Input.GetKey("down"))
        {
            print("down");
        }
    }
}