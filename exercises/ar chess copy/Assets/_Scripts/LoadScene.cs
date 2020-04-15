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

    public void SceneLoader(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void WhiteLoader()
    {
        
        cameraAnimator.SetTrigger(WhitesPlay);
        
    }

    public void BlackLoader()
    {
        
        cameraAnimator.SetTrigger(BlacksPlay);
        
    }
}
