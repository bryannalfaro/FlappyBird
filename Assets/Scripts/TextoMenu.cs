using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 2f; //Seconds to read the text
    private GameObject readyText;
    private Text texti;

    public GameObject startImage;


    void Start()
    {
        Time.timeScale = 0.0f;
        readyText = GameObject.FindWithTag("Text");
        texti = readyText.GetComponent<Text>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
            Time.timeScale = 1.0f;
                   
            Invoke("ChangeText", time);
       
    }

    void ChangeText()
    {
        texti.text = "Go!";
        startImage.SetActive(false);
        Destroy(gameObject, time);
    }
}
