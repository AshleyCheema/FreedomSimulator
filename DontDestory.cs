using UnityEngine;
using System.Collections;

public class DontDestory : MonoBehaviour
{

    public static DontDestory instance;
    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
