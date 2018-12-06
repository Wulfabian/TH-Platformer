using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioJumpKill : MonoBehaviour
{
    //skapar en rigidbody
    Rigidbody2D rbody;
    //När objectet kommer in
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om det objectet nuddar "Player" så händer följande
        if (collision.gameObject.tag == "Player")
        {
            //Detta gör att om tagen som nuddar är "Player" så kommer Splaren studsa upp och sedan förstara objectet som detta script ligger på
        
            rbody = collision.gameObject.GetComponent<Rigidbody2D>();
            rbody.velocity = new Vector2(rbody.velocity.x, collision.gameObject.GetComponent<PlayerMovement>().jumpHeight/2);
            Destroy(gameObject);
        }
    }
}
