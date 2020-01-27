using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
    public GameObject brickParticle;

    // when the ball hits a brick, this code is called

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        GM.instance.DestroyBrick(); //we can call destroyBrick because we setup static gm instance
        Destroy(gameObject);
    }
}
