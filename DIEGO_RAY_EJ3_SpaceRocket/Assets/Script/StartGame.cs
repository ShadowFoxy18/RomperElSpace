using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    GameObject desactivar;
    [SerializeField]
    GameObject activar;

    void Start()
    {
        desactivar.SetActive(true);
        activar.SetActive(false);
    }

    /// <summary>
    /// Accion del boton al ser tocado
    /// </summary>
    public void AccionBoton()
    {
        Debug.Log("Tocado");
        desactivar.SetActive(false);
        activar.SetActive(true);
    }
}
