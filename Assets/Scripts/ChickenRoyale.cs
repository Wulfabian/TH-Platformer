using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenRoyale : MonoBehaviour
{
    public string levelToLoad = "SampleScene";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject GameController = GameObject.FindWithTag("GameController");
        if (GameController != null)
        {
            ScoreTracker ScoreTracker = GameController.GetComponent<ScoreTracker>();
            if (collision.tag == "Player" && ScoreTracker.totalScore == 30)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }

}
