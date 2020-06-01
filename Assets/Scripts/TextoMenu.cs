using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 2.0f; //Seconds to read the text
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

    // Update is called once per frame
    void Update()
    {

      

    }

    void ChangeText()
    {
       
        

    }

    
}
