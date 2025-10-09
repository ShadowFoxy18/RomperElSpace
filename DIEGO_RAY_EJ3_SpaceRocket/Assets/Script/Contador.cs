using UnityEngine;

public class Contador : MonoBehaviour
{
    [SerializeField]
    KeyCode botonAccion = KeyCode.Escape;

    [SerializeField]
    GameObject pantallaJuego;

    [SerializeField]
    GameObject canvasInicio;  
    
    public float tiempoParaPulsar = 10f;
    bool tiempoActivo = false;

    public TextMeshProUGUI contadorDeSaltos;
    public TextMeshProUGUI tiempoTexto;

    int vecesTocado = 0;
    public float bateriaMotor;

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
                canvasInicio.SetActive(false);
            }
        }


        if (Tocado && tiempoActivo)
        {
            vecesTocado++;
            contadorDeSaltos.text = vecesTocado.ToString() + " veces";
        } if (vecesTocado < 20)
        {
            bateriaMotor += 1.15f;
        } else if (vecesTocado >= 20 && vecesTocado < 50)
        {
            bateriaMotor += 1.35f;
        } else if (vecesTocado >= 50 && vecesTocado < 100)
        {
            bateriaMotor += 1.75f;
        } else if (vecesTocado >= 100)
        {
            bateriaMotor += 2.15f;
        }
        
    }
}
