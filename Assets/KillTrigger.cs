using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
    public Scene lvl2;
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Player")
        {
            lvl2 = SceneManager.GetActiveScene();
            print(" You dead!");
            SceneManager.LoadScene(lvl2.name);

        }


    }
}
