using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyCollision : MonoBehaviour
{
    const int timeToReset = 3;
    Vector3 originalPosition;
    Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.localPosition;
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("ResetPiggy", timeToReset);

        if (collision.gameObject.tag != "Floor")
        {
            ScoreManager.instance.PigSmashStructure();
            Debug.Log("Score: " + ScoreManager.instance.score);

        }
        if (collision.gameObject.tag == "Structure")
        {
            ScoreManager.instance.PigSmashStructure();
        }
    }

    void ResetPiggy()
    {
        
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
        GetComponent<Rigidbody2D>().angularVelocity = 0f;
        transform.parent = parent;
        transform.localPosition = originalPosition;
        Camera.main.GetComponent<CameraFollow>().ResetCameraPosition();
    }
}
