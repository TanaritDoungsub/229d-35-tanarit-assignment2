using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float rotateSpeed = 90f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
    {
            GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().transform.up * -moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
    {
            GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(Vector3.right * -rotateSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
    {
            GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().transform.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
    {
            GetComponent<Rigidbody>().MoveRotation(GetComponent<Rigidbody>().rotation * Quaternion.Euler(Vector3.right * rotateSpeed * Time.deltaTime));
        }
    }
}
