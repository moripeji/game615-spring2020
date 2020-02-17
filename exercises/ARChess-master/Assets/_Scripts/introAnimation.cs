using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introAnimation : MonoBehaviour
{
    const string whitesPlay = "whitesPlay";
    const string blacksPlay = "blacksPlay";

    public Animator cameraAnimator; //can use this with triggers in animator controller now

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            cameraAnimator.SetTrigger(whitesPlay);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            cameraAnimator.SetTrigger(blacksPlay);
        }
    }
}
