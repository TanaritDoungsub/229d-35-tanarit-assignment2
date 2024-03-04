using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbMove : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 InputKey;


    // Update is called once per frame
    void Update()
    {
        InputKey = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rb.MovePosition((Vector3) transform.position + InputKey * 10 * Time.deltaTime);

        float Angle = Mathf.Atan2(InputKey.y, InputKey.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, Angle, 0);
    }
}
