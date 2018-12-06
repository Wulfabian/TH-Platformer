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
    //Här letar man upp scriptet "GroundCheck" och tar sedan fram funktionen groundCheck ur det scriptet.
    public GroundCheck groundCheck;
    //Skapar en Rigidbody2d med namnet rbody
    private Rigidbody2D rbody;
    //döper Weaponsign scriptet till vapen
    WeaponSign vapen;
    //döper PlayerCollect scriptet till platercollect
    public PlayerCollect playercollect;


    // Use this for initialization
    void Start()
    {
        //Tar fram Rigidbody2D:n som vi hämtade in i scriptet innan.
        rbody = GetComponent<Rigidbody2D>();
        //Letar upp scriptet
        vapen = FindObjectOfType<WeaponSign>();
        //Letar upp scriptet
        playercollect = FindObjectOfType<PlayerCollect>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gör så att man kan styra objectet horisontellt med knapparna "A,D och Arrow left/right" 
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        //Använd jump funktionen
                jump();
        //använder Switchside funktionen
                Switchside();

    }

    void jump()
    {
        //Om man klickar på space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Hittar inten touches i groundcheck. Och Om den inten är större en 0
            if (groundCheck.touches > 0)
            {
                //Jump
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
    //Skapar en funktion som kommer säga om jag är vänster eller inte vilket jag senare använder i mitt andra script som bestämmer var skyltvapnet ska vara
        void Switchside()
        {
           //Om Horizontal axeln är mer än 0 så sätts vapnets "isleft" till false
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                vapen.isleft = false;
            }

            if (Input.GetAxisRaw("Horizontal") < 0)
            {
              //Om det är mindre än 0 så sätts det till true
                vapen.isleft = true;
            }
        }
}
