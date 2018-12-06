using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillableEnemy : MonoBehaviour
{ 
    //Sålänge Objectet nuddar följande
    private void OnTriggerStay2D(Collider2D other)
    {
        //Om knappen "K" trycks ner och objectet som den nuddar är taggad med "Weapon" så händer .....
        if (Input.GetKeyDown(KeyCode.K) && (other.tag == "Weapon"))
        {
            //Om vapnets spriteRenderer är enabled så kommer objectet alltså fienden förstaras
            if(other.gameObject.GetComponent<SpriteRenderer>().enabled == true && other.gameObject.GetComponent<WeaponSign>() != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
