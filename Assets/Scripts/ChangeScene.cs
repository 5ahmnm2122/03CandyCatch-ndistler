using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    public void MoveToScene(int sceneID)
    {
        if (sceneID == 0)
        {
            var go = new GameObject("Sacrificial Lamb");
            DontDestroyOnLoad(go);

            foreach (var root in go.scene.GetRootGameObjects())
                Destroy(root);
        }

        SceneManager.LoadScene(sceneID);
    }
}
