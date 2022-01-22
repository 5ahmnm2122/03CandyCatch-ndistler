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
        }

    }

    public void GetScore()
    {
        score = scoreText.text;
    }

}
