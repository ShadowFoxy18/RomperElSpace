using TMPro;
using UnityEngine;

public class ContadorSpacios : MonoBehaviour
{
    [SerializeField]
    KeyCode botonAccion = KeyCode.Escape;

    [SerializeField]
    GameObject pantalaJuego;

    [SerializeField]
    GameObject panelCavas;

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

        if (tiempoActivo)
        {
            if (tiempoParaPulsar > 0)
            {
                tiempoParaPulsar -= Time.deltaTime;
                tiempoTexto.text = tiempoParaPulsar.ToString("F2");
            }
            else
            {
                tiempoActivo = false;
                tiempoTexto.text = "Se acabo el tiempo";
                pantalaCanvas.SetActive(false);
            }
        }

        
        if (Tocado && tiempoActivo)
        {
            vecesTocado++;
        }
        
    }
}
