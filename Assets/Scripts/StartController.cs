using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{

    [SerializeField]
    private UnityEvent ShowStart;
    void Start()
    {
        if (PlayerPrefs.HasKey("start"))
        {
            StartEvent();
        }
    }

    public void StartEvent()
    {
        PlayerPrefs.SetInt("start", 1);
        ShowStart.Invoke();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
