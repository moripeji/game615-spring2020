using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    const int MAX_PLAYER_HEALTH = 10;
    int playerHealth = MAX_PLAYER_HEALTH;
    void Start()
    {
        
    }
    
    public void playerInjured()
    {
        if (playerHealth > 0)
        {
            playerHealth--;
            //play injure animation
        }

        if (playerHealth == 0)
        {
            //restart the level and play death animation
        }
    }

    public void playWalkSound()
    {
        //GetComponent<AudioSource>().PlayOneShot();
    }

    void Update()
    {

    }

}
