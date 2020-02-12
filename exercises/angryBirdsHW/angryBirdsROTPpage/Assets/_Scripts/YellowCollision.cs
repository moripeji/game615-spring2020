using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCollision : MonoBehaviour
{
    public GameObject yellowExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(yellowExplosion, transform.position, Quaternion.identity);
        ScoreManager.instance.PigSmashYellow();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
