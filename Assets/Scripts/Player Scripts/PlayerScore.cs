using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public Text scoreText;
    [SerializeField] int score = 0;
    public NameSceneMain nameSceneMain;

    void Start()
    {
        scoreText.text = "0";
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            transform.position = new Vector2(0, 100);
            target.gameObject.SetActive(false);
            StartCoroutine(LoadOutro());
        }

        if (target.tag == "Fruit")
        {
            Debug.Log("fruit catch");
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = score.ToString();
        }
    }

    IEnumerator LoadOutro()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        nameSceneMain.GetScore(); 
        SceneManager.LoadScene(2);
    }

}
