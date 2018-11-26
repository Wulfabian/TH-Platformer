using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public int touches;
    //När man först nuddar ett object, "TriggerEnter"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Adderar 1 till inten "touches"
        touches++;
    }
    //När man lämnar en collider
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Subtraherar 1 till inten "touches"
        touches--;
    }

}
