using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    void trunLeft()
    {
        transform.Rotate(Vector3.up, -90);
    }
    
    void turnRight()
    {
        transform.Rotate(Vector3.up, 90);
    }
}
