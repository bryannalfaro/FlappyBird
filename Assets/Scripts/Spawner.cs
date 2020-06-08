using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

/**
 * Bryann Alfaro
 * Referencia: Clases y videos de youtube
 * Controlar los obstaculos del juego
 */
public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject obstaculo;

    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(obstaculo);
        newpipe.transform.position = transform.position + new UnityEngine.Vector3(0, Random.Range(-height, height), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(obstaculo);
            newpipe.transform.position = transform.position+ new UnityEngine.Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15);
            timer = -0;
        }

        timer += Time.deltaTime;
        
    }
}
