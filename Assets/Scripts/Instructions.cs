using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnOffInstructions());
    }

    IEnumerator TurnOffInstructions()
    {
        yield return new WaitForSecondsRealtime(5f);
        this.gameObject.SetActive(false);
    }
}
