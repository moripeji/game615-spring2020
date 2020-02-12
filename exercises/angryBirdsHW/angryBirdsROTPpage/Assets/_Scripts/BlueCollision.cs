using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCollision : MonoBehaviour
{

    public GameObject blueExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(blueExplosion, transform.position, Quaternion.identity);
        ScoreManager.instance.PigSmashBlue();
        Destroy(gameObject);
    }
}
