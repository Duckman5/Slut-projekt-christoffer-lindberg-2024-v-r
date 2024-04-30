using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rg;
    public float speed = 1f;

    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg.AddForce(transform.forward* speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rg.AddForce(-transform.right* speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rg.AddForce(transform.right * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rg.AddForce(-transform.forward * speed);
        }
        else
        {
            rg.velocity = new Vector3(0, 0, 0);
        }
    }
}
