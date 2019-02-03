using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeController : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;
    // Start is called before the first frame update
    void Start()
    {
        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;

        }

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * thrust);


        if (Input.GetKeyDown("left"))
        {
            rb.AddForce(transform.up * thrust);
                        print("left key was pressed");

        }

        if (Input.GetKeyDown("right"))
        {
                        print("right key was pressed");

            // rb.AddForce(transform.down * thrust);
        }

    }
}
