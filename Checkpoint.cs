using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(68.97f, 2.736f, 0f);

    }
}



