using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUp = 0;
        if (Input.GetKey("space"))
        {
            moveUp = speed;
        }

        Vector3 movement = new Vector3(moveHorizontal, moveUp, moveVertical);
        rb.AddForce (movement * speed);
    }
}
