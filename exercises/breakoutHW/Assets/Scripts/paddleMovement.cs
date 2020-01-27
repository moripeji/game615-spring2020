using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode leftKey;
    public KeyCode rightKey;
    public float paddleSpeed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(rightKey) && transform.position.x < 7.5f)
        {
            transform.position = new Vector3(transform.position.x + paddleSpeed, transform.position.y, 0);
        }

        if (Input.GetKey(leftKey) && transform.position.x > -7.5f)
        {
            transform.position = new Vector3(transform.position.x - paddleSpeed, transform.position.y, 0);
        }
    }
}
