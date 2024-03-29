using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{

    [SerializeField] Text timer;

    private float currentTime = 0f;
    private float startingTime = 60f;
    public NameSceneMain nameSceneMain;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timer.text = currentTime.ToString("00:00");

        if (timer.text == "00:10")
        {
            timer.color = Color.red;
            timer.fontSize = 40;
            StartCoroutine(timerSize());
        }

        if (timer.text == "00:00")
        {
            nameSceneMain.GetScore(false);
            
            SceneManager.LoadScene(2);
        }
    }

    IEnumerator timerSize()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        timer.fontSize = 20;
    }
}
