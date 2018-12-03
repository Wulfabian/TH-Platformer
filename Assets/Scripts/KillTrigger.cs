using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
    //Denna "public Scene" är ingen bestämd scene utan man får ändra den manuellt
    public Scene lvl;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            
        //Om Killtriggeren nuddar spelaren
        if (collision.tag == "Player")
        {
            //Den hittar den activa scenen, printar sedan "You dead!" Och sen laddar om scenen som den hittade.
            lvl = SceneManager.GetActiveScene();
            print(" You dead!");
            SceneManager.LoadScene(lvl.name);

        }


    }
}
