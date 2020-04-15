using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PieceBehavior : MonoBehaviour
{

    NavMeshAgent agent;
    Animator anim;
    public Transform enemy;
    const int MAX_HEALTH = 20;
    int health = MAX_HEALTH; //we need to introduce a health element so that the pieces know when to attack/ when they are being attacked

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        //StartCoroutine(waitForAttack());
    }

    public void underAttack()
    {
        
        health--; //any time this function is called, we lose some health

        if (health == 0)
        {
            GameState.eliminatePiece(transform); //call the eliminate piece function when health comes to zero or less
            anim.SetTrigger("death");
            Destroy(gameObject, 5f);

        }

    }


    /*public IEnumerator waitForAttack()
    {
        yield return new WaitForSeconds(2f);
        if (enemy)
        {
            anim.SetTrigger("attack");
            enemy.GetComponent<PieceBehavior>().underAttack();
        }
    } */

    // Update is called once per frame
    void Update()
    {
        
        //anim.SetTrigger("attack"); //can call a trigger to transition into attack state

        //what are the conditions to walk?

        if (agent.velocity.magnitude > 0.1f) //use magnitude because VELOCITY is not "speed"
        {
            anim.SetTrigger("walk");
        }

        

        if (agent.velocity.magnitude < 0.1f)
        {
            anim.SetTrigger("idle");
        }


        //what are the conditions to attack?
        //anim.SetTrigger("attack");

        if (enemy) //AND distance <2 ? because sword length is 2?
        {
            anim.SetTrigger("attack");
            enemy.GetComponent<PieceBehavior>().underAttack();
        }
    }
}
