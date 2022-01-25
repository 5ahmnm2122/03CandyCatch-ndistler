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
            Destroy(target.gameObject);
            StartCoroutine(LoadOutro());
        }

        if (target.tag == "Fruit")
        {
            Debug.Log("fruit catch");
            Destroy(target.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }

    IEnumerator LoadOutro()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        nameSceneMain.GetScore(true); 
        SceneManager.LoadScene(2);
    }

}
