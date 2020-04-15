using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update

    const int MAX_PLAYER_HEALTH = 10;
    int playerHealth = MAX_PLAYER_HEALTH;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

}
