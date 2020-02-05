using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    //public int lives = 1;

    public float resetDelay = 0.5f; //time it takes to restart game

    const int StructureHitPoint = 1;
    const int PiggyHitPoint = 5;

    //public Text scoreText; //score counter
    //public Text livesText; //lives counter

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
        Debug.Log("Score: " + score);
        //scoreText.text = "Score: " + score;
    }

    public void PigSmashStructure()
    {
        score = score + PiggyHitPoint;
    }

    private void Reset()
    {
        Time.timeScale = 1f;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //when the game ends, reset layout

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
