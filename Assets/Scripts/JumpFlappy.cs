﻿using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


/**
 * Bryann Alfaro
 * Referencia: Clases y videos de youtube
 * Clase para controlar el salto del flappy
 */
public class JumpFlappy : MonoBehaviour
{
    public manager manager;
    public float velocity = 1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = UnityEngine.Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.GameOver();
    }
}
