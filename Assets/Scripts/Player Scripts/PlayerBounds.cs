using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 coor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minX = -coor.x + 0.3f;
        maxX = coor.x - 0.3f;    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temppos = transform.position;

        if (temppos.x > maxX)
        {
            temppos.x = maxX;
        }

        if (temppos.x < minX)
        {
            temppos.x = minX;
        }

        transform.position = temppos;

    }
}
