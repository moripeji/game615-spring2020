using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCollision : MonoBehaviour
{
    public GameObject blackExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Instantiate(blackExplosion, transform.position, Quaternion.identity);
        ScoreManager.instance.PigSmashBlack();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
