using TMPro;
using UnityEngine;

public class ContadorSpacios : MonoBehaviour
{
    [SerializeField]
    KeyCode botonAccion = KeyCode.Escape;

    [SerializeField]
    GameObject pantalaJuego;

    public float tiempoParaPulsar = 10f;
    bool tiempoActivo = false;

    public TextMeshProUGUI contadorDeSaltos;
    public TextMeshProUGUI tiempoTexto;

    int vecesTocado = 0;


    // Update is called once per frame
    void Update()
    {
        bool Tocado = Input.GetKey(botonAccion);
        if (pantalaJuego != null) tiempoActivo = true;

        
        if (Tocado && tiempoActivo)
        {
            vecesTocado++;
        }
        
    }
}
