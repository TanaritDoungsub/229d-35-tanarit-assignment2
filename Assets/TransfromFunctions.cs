using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransfromFunctions : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float trunSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -trunSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, trunSpeed * Time.deltaTime);
    }
}
