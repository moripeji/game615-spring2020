using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    const string WhitesPlay = "WhitesPlay";
    const string BlacksPlay = "BlacksPlay";
    public Animator cameraAnimator;
    //string playerCol = InputController.playerColor;
   // string aiCol = AI.ai_player;

    public void SceneLoader(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void WhiteLoader()
    {
        string wPlayer = "White";
        InputController.playerColor = wPlayer;
        AI.ai_player = "Black";

        cameraAnimator.SetTrigger(WhitesPlay);
        
        
        
    }

    public void BlackLoader()
    {
        string bPlayer = "Black";
        InputController.playerColor = bPlayer;
        AI.ai_player = "White";

        cameraAnimator.SetTrigger(BlacksPlay);
        
    }
}
