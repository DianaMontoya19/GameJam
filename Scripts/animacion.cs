using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    private float tiempoActual;
    private bool tiempoActivado = false;

    private void Start()
    {
        ActivarTemporizador();

        
    }
    void Update()
    {
        if (tiempoActivado)
        {
            CambiarContador();
        }      
    }

    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;
        if(tiempoActual <= 0)
        {
            Debug.Log("Derrota");
            tiempoActivado = false;
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;
    }
    public void ActivarTemporizador()
    {
        tiempoActual += tiempoMaximo;
    }

    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }
}
