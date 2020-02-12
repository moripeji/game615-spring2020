using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyCollision : MonoBehaviour
{
    const int timeToReset = 10;
    Vector3 originalPosition;
    Transform parent;
    public GameObject explosion;
    private GameObject red;
    private GameObject black;
    private GameObject yellow;
    private GameObject blue;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.localPosition;
        parent = transform.parent;
        red = GameObject.FindWithTag("EnemyRed");
        black = GameObject.FindWithTag("EnemyBlack");
        yellow = GameObject.FindWithTag("EnemyYellow");
        blue = GameObject.FindWithTag("EnemyBlue");
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
        if (collision.gameObject.tag == "EnemyBlack")
        {
            ScoreManager.instance.PigSmashBlack();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(black);
        }
        if (collision.gameObject.tag == "EnemyRed")
        {
            ScoreManager.instance.PigSmashRed();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(red);
        }
        if (collision.gameObject.tag == "EnemyYellow")
        {
            ScoreManager.instance.PigSmashYellow();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(yellow);
        }
        if (collision.gameObject.tag == "EnemyBlue")
        {
            ScoreManager.instance.PigSmashBlue();
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(blue);
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
