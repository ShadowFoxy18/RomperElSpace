using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class CoheteMovimiento : MonoBehaviour
{
    [SerializeField]
    GameObject canvaInicio;

    [SerializeField]
    GameObject canvaCohete;

    public float velocidad = 2f;

    public GameObject cohete;  

    public TextMeshProUGUI fuel;
    public TextMeshProUGUI altura;
    
    float fuelTotal;
    float fuelRetante;

    float potencia;

    float alturaOptenida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Se debera cambiar cuando descubra como obtenerlo
        fuelTotal = 100f;
        fuelRetante = fuelTotal;
        canvaCohete.SetActive(false);
        potencia = velocidad * Time.deltaTime;
    }


    float Porcentaje(float numero)
    {
        float porcentaje = (numero * 100) / fuelTotal;
        Debug.Log(porcentaje);

        return porcentaje * 100f;
    }

    float AlturaMaxObjeto(float altura)
    {
        Vector3 alturaCohete = cohete.transform.localPosition;
        float alturaMax = 0f;
        


        return alturaMax;
    }


    // Update is called once per frame
    void Update()
    {
        if (!(canvaInicio != null))
        {
            canvaCohete.SetActive(true);
            if (fuelRetante > 0)
            {
                cohete.transform.Translate(0, potencia, 0);
                fuelRetante--;
                fuel.text = "COMBUSTIBLE: " + (Porcentaje(fuelRetante)).ToString("F2") + "%";
            }
        }
    }
}
