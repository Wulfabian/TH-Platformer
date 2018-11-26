using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //När ett object nuddar (kolliderar) med detta object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Om obektet som nuddar har tagen "Player" (Alltså vår spelare)
        if (collision.gameObject.tag == "Player")
        {
            //Hitta den aktiva scenen och ladda sedan om den.
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
