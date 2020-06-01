﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseBehaviour : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToglePause();
        }
    }

    public void ToglePause()
    {
        pauseMenu.SetActive(!isPaused);
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    public void BackMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
