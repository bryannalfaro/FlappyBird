using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/**
 * Bryann Alfaro
 * Referencia: Clases y videos de youtube
 * Activar el menu al inicio del juego
 * 
 */
public class TextoMenu : MonoBehaviour
{
    public float time = 2.0f; 
    private float time1 = 1.0f;
    public GameObject readyText;
    public GameObject flappy;   

    void Start()
    {
        StartCoroutine("StartDelay");

        
    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }
        readyText.gameObject.SetActive(false);
        flappy.gameObject.SetActive(true);
        Time.timeScale = 1;
    }  
}
