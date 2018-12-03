using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Hur mycket poäng får man per coin
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel och sätt den till resultatet
            //av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {

                //Skapa en temporär variabel "tracker" och sätt den till 
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score;
                    
                }
                else
                {
                    //Om det inte funkar så printa ut att ScoreTrackern saknar GameController så att man vet vad som gått fel.
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte.");
            }
            //Förstör coinet
            Destroy(gameObject);

        }
    }
}
