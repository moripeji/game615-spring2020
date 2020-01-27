using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTest : MonoBehaviour
{

    //public bool newGame = true;
    public float magnitude = 800f;

    void launchBall()
    {
        transform.position = new Vector3(0,-3,0);

        float forceX = Random.Range(-0.9f, 1f);
        float forceY = Random.Range(-0.5f, 0.5f);

        Vector3 force = new Vector3(forceX, forceY, 0);

        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().AddForce(force * magnitude);
    }
    // Start is called before the first frame update
    void Start()
    {
        launchBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
