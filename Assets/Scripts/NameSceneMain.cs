using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameSceneMain : MonoBehaviour
{
    public Text displayPlayerName;
    public Text scoreText;
    private string playerName;
    private string score;
    bool hasLost;

    public void Awake()
    {
        displayPlayerName.text = NameSceneIntro.introScene.playerName;
        playerName = NameSceneIntro.introScene.playerName;
        DontDestroyOnLoad(gameObject);
       
    }

    void OnLevelWasLoaded(int level)
    {
        if (level == 2)
        {
            GameObject.Find("Score").GetComponent<Text>().text = "Score: " + score;
            GameObject.Find("Name").GetComponent<Text>().text = playerName;
            if (hasLost)
            {
                GameObject.Find("WonLose").GetComponent<Text>().text = "GAME OVER!";
            }
        }

    }

    public void GetScore(bool hasTouchedBomb)
    {
        hasLost = hasTouchedBomb;
        score = scoreText.text;
    }

}
