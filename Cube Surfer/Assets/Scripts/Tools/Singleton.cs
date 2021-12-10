using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton<T> : MonoBehaviour where T : singleton<T>
{

    private static T _instance;

    public static T Instance => _instance;

    private protected void Awake()
    {
        if (_instance != null)
        {
            Debug.LogError("Prevented new instance of singleton");
        }
        else
        {
            _instance = (T)this;
        }
    }

    private void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
}