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
    public WeaponSign weapon;
    public bool isleft;

    // Use this for initialization
    void Start()
    {
        //Tar fram Rigidbody2D:n som vi hämtade in i scriptet innan.
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
            if (groundCheck.touches > 0)
            {
                //Jump
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            isleft = false;
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            isleft = true;
        }


        if (isleft)
        {
            weapon.transform.localPosition = new Vector3(Mathf.Abs(weapon.transform.localPosition.x) * -1, weapon.transform.localPosition.y, weapon.transform.localPosition.z);
            weapon.transform.localScale = new Vector3(Mathf.Abs(weapon.transform.localScale.x) * -1, weapon.transform.localScale.y, weapon.transform.localScale.z);
        }
        if (isleft)
        {
            weapon.transform.localPosition = new Vector3(Mathf.Abs(weapon.transform.localPosition.x), weapon.transform.localPosition.y, weapon.transform.localPosition.z);
            weapon.transform.localScale = new Vector3(Mathf.Abs(weapon.transform.localScale.x), weapon.transform.localScale.y, weapon.transform.localScale.z);
        }
    }
}
