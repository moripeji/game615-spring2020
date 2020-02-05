using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    const int StructureHitPoint = 1;
    const int PiggyHitPoint = 5;
    //public Text scoreText; //score counter

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

    public void StructureSmash()
    {
        score = score + StructureHitPoint;
        Debug.Log("Score: " + GetScore());
        //scoreText.text = "Score: " + score;
    }

    public void PigSmashStructure()
    {
        score = score + PiggyHitPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
