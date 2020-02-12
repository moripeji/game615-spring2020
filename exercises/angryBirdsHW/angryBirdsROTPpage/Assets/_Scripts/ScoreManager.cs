using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    //public int lives = 1;

    public float resetDelay = 3f; //time it takes to restart game

    const int StructureHitPoint = 1; //if the structure collides with itself (due to the pig in SOME WAY), get one point
    const int PiggyHitPoint = 5; //if the pig HITS the structure directly, get 5 points
    const int PiggyHitBlack = 10; //if the pig hits a black bird, get 10 points
    const int PiggyHitRed = 15; //if the pig hits a red bird, get 15 points
    const int PiggyHitYellow = 20; //if the pig hits a yellow bird, get 20 points
    const int PiggyHitBlue = 25; //if the pig hits a blue bird, get 25 points

    public Text scoreText; //score counter
    //public Text livesText; //lives counter

    public GameObject explosion;
    public const int explosionTime = 3;
    //public GameObject gameOver;
    //public GameObject youWon;

    public static ScoreManager instance = null;


    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        {
            instance = this; //do we have a GM yet? 
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void SmashStructure()
    {
        score = score + StructureHitPoint;
        scoreText.text = "Score: " + score;
    }

    public void PigSmashStructure()
    {
        score = score + PiggyHitPoint;
        scoreText.text = "Score: " + score;
    }

    public void PigSmashRed()
    {
        score = score + PiggyHitRed;
        scoreText.text = "Score: " + score;
    }

    public void PigSmashBlack()
    {
        score = score + PiggyHitBlack;
        scoreText.text = "Score: " + score;
    }

    public void PigSmashYellow()
    {
        score = score + PiggyHitYellow;
        scoreText.text = "Score: " + score;
    }

    public void PigSmashBlue()
    {
        score = score + PiggyHitBlue;
        scoreText.text = "Score: " + score;
    }


    public void DestroyBird()
    {

    }
    private void Reset()
    {
        Time.timeScale = 3f;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //when the game ends, reset layout

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
