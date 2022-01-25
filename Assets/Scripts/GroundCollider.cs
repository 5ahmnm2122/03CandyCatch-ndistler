using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D targetOnGround)
    {
        if (targetOnGround.tag == "Bomb")
        {
            Destroy(targetOnGround.gameObject);
        }

        if (targetOnGround.tag == "Fruit")
        {
            Destroy(targetOnGround.gameObject);
        }
    }
}
