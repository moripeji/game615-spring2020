using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    public int lives = 3; //number of lives
    public int bricks = 50; //bricks available in game
    public float resetDelay = 0.1f; //time it takes to restart game
    public Text livesText; //interactive life counter
    public GameObject gameOver; //controlling game over message
    public GameObject youWon; //controlling you won! message
    public GameObject bricksPrefab; //use to instantiate new bricks when needed
    public GameObject paddle; //use to create new paddle when paddle loses life
    public GameObject deathParticles; //particles that come when paddle is destroyed
    public GameObject newBall;
    public static GM instance = null;
    //makes life easier to get values from GM by making this instance of the GM script
    /* by making instance a static variable, it means that we are going to access it
     * via the class-- not as an instance of the class
     * so this variable is accessible from our other scripts
     * if we want to access GM, we can type gm.instance.bricks to access bricks, etc.
     * makes it easier to change values in gm
     */

    private GameObject clonePaddle;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this; //check-- do we have a GM yet? if not, set it to THIS
        }

        else if (instance != this)
        {
            Destroy(gameObject);

        }
        Setup();

        /*the above just prevents multiple GM from existing*/
    }

    public void Setup()
    {
        //clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
       // Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }

    public void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = .25f; //make it slow motion for fun
            Invoke("Reset", resetDelay); //wait one second, reset game
        }

        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f; //slow-mo
            Invoke("Reset", resetDelay);
        }
    }

    private void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //when the game ends, we reload the scene and restart the game
    }
    // Update is called once per frame

    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
       // Destroy(clonePaddle);
       // Invoke("CreatePaddle", resetDelay);
        CheckGameOver(); //just lost a life, check if the game ended
    }

    /*public void CreatePaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject; //make a new paddle when players lose life
    }*/

    public void DestroyBrick()
    {
        bricks--;
        CheckGameOver(); //was that the last brick to be destroyed? check if the game is over
    }
}
