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
    
    [SerializeField]
    public Contador contadorScript;

    public float fuelTotal;
    float fuelRetante;


    float alturaMax;

    bool iniciado = false;

    public Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvaInicio.SetActive(true);
        canvaCohete.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }


    float Porcentaje(float numero)
    {
        float porcentaje = (numero * 100) / fuelTotal;
        Debug.Log(porcentaje);

        return porcentaje;
    }

    void AlturaMaxObjeto()
    {
        Vector3 alturaCohete = cohete.transform.localPosition;
        if (alturaCohete.y > alturaMax) alturaMax = alturaCohete.y;
        altura.text = "ALTURA MAXIMA: " + alturaMax.ToString("F2") + " m";
     }
    
        // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        fuel.text = "COMBUSTIBLE: " + (Porcentaje(fuelRetante)).ToString("F2") + "%";
        AlturaMaxObjeto();

        if (!(canvaInicio.activeSelf) && !iniciado)
        {
            canvaCohete.SetActive(true);
            fuelTotal = contadorScript.bateriaMotor;
            fuelRetante = fuelTotal;
            iniciado = true;
        }
        if (fuelRetante > 0 && iniciado)
        {
            
            rb.AddForce(0, velocidad * Time.deltaTime, 0, ForceMode.Impulse);
            fuelRetante -= 3 * Time.deltaTime;
        }
        else fuel.text = "COMBUSTIBLE: 0%";
    }
}
