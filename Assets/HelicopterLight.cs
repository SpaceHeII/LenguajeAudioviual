using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterLight : MonoBehaviour
{
    public float intensity = 1.0f; // Intensidad de la luz
    public Transform target; // Punto al que apunta la luz

    private Light helicopterLight; // Referencia al componente Light

    void Start()
    {
        // Obtener el componente Light del GameObject
        helicopterLight = GetComponent<Light>();

        // Asegurarse de que hay un punto de destino
        if (target == null)
        {
            Debug.LogWarning("No se ha asignado un punto de destino para la luz. Asigna un objeto al campo 'target' en el inspector.");
        }
    }

    void Update()
    {
        // Actualizar la intensidad de la luz
        helicopterLight.intensity = intensity;

        // Apuntar la luz hacia el punto de destino
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}

