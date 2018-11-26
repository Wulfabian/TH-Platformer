using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Denna public floaten säger helt enkelt hur snabbt rottan rör sig. Eftersom det är 
    //en public float så kan man ändra det inne i unity.
    public float moveSpeed = 2f;
    private bool isLeft = true;

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move(bool flip)
    {
        //Om flip är lika med sant så ändra isLeft till en falsk isLeft
        if (flip == true)
        {
            isLeft = !isLeft;
        }
        //Om isLeft är sant 
        if (isLeft == true)
        {
            //Använd den negativa moveSpeed i X vector
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            //Använd possitiv 1 i X,Y och Z
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //Här är det tvärt om från där uppe. Här har vi den originella movespeed I rbody.velocity
            //Och -1 I transform.localScale X
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om objektet med detta script nuddar ett objekt med taggen "InvisibleWall"
        if (collision.tag == "InvisibleWall")
        {
            //sätt Move boolen till sant
            Move(true);
        }
    }
}