using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenRoyale : MonoBehaviour
{
    //Denna variablen använder jag till funktioner där man har en max score. 
    //Eller om man når en viss mängd poäng så händer det något.
    public int ScoreNeed;
    //En public string som man kan ändra i unity. Man skriver in namnet på scenen som man sedan vill ladda.
    public string levelToLoad = "SampleScene";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject GameController = GameObject.FindWithTag("GameController");
        if (GameController != null)
        {
            //Hitta componenten ScoreTracker
            ScoreTracker ScoreTracker = GameController.GetComponent<ScoreTracker>();
            //Om taggen "Player" och om funktionen "totalScore" i ScoreTracker ör lika med inten"ScoreNeed"
            if (collision.tag == "Player" && ScoreTracker.totalScore == ScoreNeed)
            {
                //Ladda om scenen som man valt inne i unity
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }

}
