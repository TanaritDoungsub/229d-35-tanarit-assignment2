using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody RB3D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            RB3D.AddForce(0, 0, 5);
        }

        if (Input.GetKey("a"))
        {
            RB3D.AddForce(5, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            RB3D.AddForce(0, 0, -5);
        }

        if (Input.GetKey("d"))
        {
            RB3D.AddForce(-5, 0, 0);
        }
    }
}
