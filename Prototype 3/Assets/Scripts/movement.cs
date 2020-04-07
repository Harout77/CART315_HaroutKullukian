using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{


    public Rigidbody rb;



    public float forcemovement = 1000f;
    public float sidemovement = 500f;
    public float jump = 1000f;



    // Update is called once per frame
    void FixedUpdate()
    {

        // Add force to player
        rb.AddForce(0, 0, forcemovement * Time.deltaTime);

        // move right
        if (Input.GetKey("d"))

        {
            rb.AddForce(sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        /// mive left

        if (Input.GetKey("a"))

        {
            rb.AddForce(-sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        //// jump 
        if (Input.GetKey("space"))
        {
            if (transform.position.y < 1.05f)
            {
                rb.AddForce(Vector3.up * jump);

            }


        }


        if (rb.position.y < -1f)
        {

            FindObjectOfType<gameManager>().GameOver();

        }

    }
}
