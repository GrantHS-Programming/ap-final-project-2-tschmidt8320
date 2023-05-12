using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFront : MonoBehaviour
{
    public TarodevController.PlayerController foo;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameObject.Find("player").transform.position;
    }

    public double baz = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position = GameObject.Find("player").transform.position;
        if (Input.GetKey("left"))
        {
            transform.position += Vector3.left * 5;
        }
        if (Input.GetKey("right"))
        {
            transform.position += Vector3.right * 5;
        }
        
    }
}
