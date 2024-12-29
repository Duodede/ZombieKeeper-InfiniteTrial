using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    public GameObject menuUI;
    public bool isPause;
    void Start()
    {
        Time.timeScale = 1.0f;
    }
    void Update()
    {
        if(isPause)
        {
            Time.timeScale = 0f;
        }
        else if(Time.timeScale != 1.0f)
        {
            Time.timeScale = 1f;
        }
    }
    public void Pause()
    {
        isPause = !isPause;
        menuUI.SetActive(isPause);
    }
}
