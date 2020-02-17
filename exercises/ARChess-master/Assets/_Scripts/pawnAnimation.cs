using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawnAnimation : MonoBehaviour
{
    public Animator pawnAnimator;

    const string attackPawn = "attackPawn";
    const string idlePawn = "idlePawn";
    const string movePawn = "movePawn";
    const string rotateRightPawn = "rotateRightPawn";
    const string rotateLeftPawn = "rotateLeftPawn";
    const string diePawn = "diePawn";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the player chooses A, pawn will attack.
        if (Input.GetKeyDown(KeyCode.A))
        {
            pawnAnimator.SetTrigger(attackPawn);
        }

        //if the player chooses M, pawn will move forward.
        if (Input.GetKeyDown(KeyCode.M))
        {
            pawnAnimator.SetTrigger(movePawn);
        }

        //if the player chooses R, pawn will rotate right.
        if (Input.GetKeyDown(KeyCode.R))
        {
            pawnAnimator.SetTrigger(rotateRightPawn);
        }

        //if the player chooses L, pawn will rotate left.
        if (Input.GetKeyDown(KeyCode.L))
        {
            pawnAnimator.SetTrigger(rotateLeftPawn);
        }

        //if the player does not choose anything, the pawn will default to idle
        /*else
        {
            pawnAnimator.SetTrigger(idlePawn);
        }*/
    }
}
