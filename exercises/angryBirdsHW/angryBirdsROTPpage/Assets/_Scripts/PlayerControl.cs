using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject piggy;
    public float power;
    private Rigidbody2D piggyBody;

    // Start is called before the first frame update
    void Start()
    {
        piggyBody = piggy.GetComponent<Rigidbody2D>();
        piggyBody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseInWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z)); //constructed position of mouse on the screen from cam perspective

        Vector3 direction = mouseInWorld - transform.position;

        float cosAlpha = Vector3.Dot(Vector3.right, direction.normalized); //cos alpha
        float alpha = Mathf.Acos(cosAlpha);

        transform.rotation = Quaternion.Euler(0, 0, alpha*Mathf.Rad2Deg); //rotates the cannon around the Z axis by alpha angle, converts radians to degrees


        if (Input.GetButtonDown("Fire1"))
        {
            piggy.transform.parent = null;
            piggyBody.gravityScale = 1;
            piggyBody.AddForce(direction*power);
        }

    }
}
