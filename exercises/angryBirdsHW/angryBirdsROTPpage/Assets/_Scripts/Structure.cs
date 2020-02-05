using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.instance.SmashStructure();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
