using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCollision : MonoBehaviour
{
    public GameObject redExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(redExplosion, transform.position, Quaternion.identity);
        ScoreManager.instance.PigSmashRed();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
