using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Det Rangen gör är att den sätter en max hastighet och hopphöjd för de två variablerna som är under.
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    public GroundCheck groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gör så att man kan styra objectet horisontellt med knapparna "A,D och Arrow left/right" 
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        //Om man klickar på space
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //Hittar inten touches i groundcheck. Och Om den inten är större en 0
           if( groundCheck.touches > 0)
            {
                //Jump
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}
