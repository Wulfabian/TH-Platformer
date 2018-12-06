using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalMovement : MonoBehaviour
{
    //skapar en public float som heter moveSpeed med värdet 2
    public float moveSpeed = 2f;
    //skapar en public bool som heter isUp och sätter den till true
    public bool isUp;
    //skapar en private variabel till "Rigidbody2D" som heter rbody
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //säger att rbody är lika med hämta komponenten "Rigidbody2D"
        rbody = GetComponent<Rigidbody2D>();
        //sätter Move till false
        Move(false);
    }

    //skapar en void Move
    void Move(bool flip)
    {
        //ifall flip är true
        if (flip == true)
        {
            //sätt isUp till tvärtom 
            isUp = !isUp;
        }
        //ifall isUp är true
        if (isUp == true)
        {
            //sääter på moveSpeed´s värde på y axeln
            rbody.velocity = new Vector2(rbody.velocity.x, moveSpeed);
        }
        //om inte
        else
        {
            //sätt på moveSpeed's värde negativt på y axeln
            rbody.velocity = new Vector2(rbody.velocity.x, -moveSpeed);
        }
    }
    //närr triggern går på
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ifall objektet har taggen "InvisibleWall"
        if (collision.tag == "InvisibleWall")
        {
            //sätt move till true
            Move(true);
        }
    }

}