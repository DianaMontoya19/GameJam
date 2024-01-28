using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb2d;
    public float fuerzaSalto = 3f;

    private AudioSource sonidoDeSalto;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sonidoDeSalto = GetComponent<AudioSource>();
       
    }
    private void FixedUpdate()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(Horizontal * velocidad, rb2d.velocity.y);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector2 fuerza = Vector2.up * fuerzaSalto;
            rb2d.AddForce(fuerza, ForceMode2D.Impulse);
            sonidoDeSalto.Play();
        }
    }
}
