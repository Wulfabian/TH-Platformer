using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollect : MonoBehaviour
{
    public WeaponSign weaponsign;
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {


        if (Input.GetKeyDown(KeyCode.E) && (collision.tag == "Player"))
        {
            weaponsign.rend.enabled = true;
            weaponsign.transform.parent.GetComponent<PlayerMovement>().weapon = weaponsign;
            Destroy(gameObject);
        }


    }
}
