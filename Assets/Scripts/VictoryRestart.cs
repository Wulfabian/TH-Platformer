using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryRestart : MonoBehaviour
{
    //En string som gör att man kan välja vilken scene som ska laddas om senare
    public string levelToLoad;
 
    // Update is called once per frame
    void Update()
    {
        //När man klickar space så startade scenen som man valt i unity om
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
