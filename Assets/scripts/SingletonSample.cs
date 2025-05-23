using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSample : MonoBehaviour
{
    // Start is called before the first frame update
    public static SingletonSample instance;

    void Awake()
    {
        CheckInstance();
    }

    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
