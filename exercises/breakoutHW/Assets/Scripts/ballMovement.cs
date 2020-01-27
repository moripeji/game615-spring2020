using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{

    public float ballInitialVelocity = 10f;

    public KeyCode startKey;
    private Rigidbody rb;
    private bool ballInPlay;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(startKey)) && ballInPlay == false);
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }
    }
}
