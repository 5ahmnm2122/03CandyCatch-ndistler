using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameSceneIntro : MonoBehaviour
{
    public static NameSceneIntro introScene;
    public InputField inputField;

    public string playerName;
    public Button startButton;

    private void Awake()
    {
        if (introScene == null)
        {
            introScene = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetPlayerName()
    {
        playerName = inputField.text;

        if(playerName.Length >= 4)
        {
            startButton.interactable = true;
        }
    }

}
