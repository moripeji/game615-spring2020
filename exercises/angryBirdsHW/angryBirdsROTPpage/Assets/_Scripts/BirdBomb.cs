using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBomb : MonoBehaviour
{
    public GameObject explosion;
    public const int explosionTime = 3;

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
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Invoke("Bomb", explosionTime);
        }
    }

    public void Bomb()
    {
        Destroy(gameObject);
    }
}
