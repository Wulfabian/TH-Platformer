using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI
public class ScoreTracker : MonoBehaviour
{
    //Texten
    public TextMeshProUGUI scoreText;
    public int totalScore;
    public int maxSceneScore;

    private void Update()
    {
        //Allt i stringen är fast förutom {0} vilket blir inten totalScore.
        scoreText.text = string.Format("Score: {0} / {1}", totalScore, maxSceneScore);
    }
}
