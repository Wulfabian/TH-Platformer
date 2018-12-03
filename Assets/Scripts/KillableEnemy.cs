using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillableEnemy : MonoBehaviour
{ 
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKeyDown(KeyCode.K) && (collision.tag == "Weapon"))
        {
            if(collision.gameObject.GetComponent<SpriteRenderer>().enabled == true && collision.gameObject.GetComponent<WeaponSign>() != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
