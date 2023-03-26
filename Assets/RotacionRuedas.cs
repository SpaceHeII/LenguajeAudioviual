using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RotacionRuedas : MonoBehaviour
{
    public Transform ruedaFrenteIz, ruedaFrenteDe, ruedaAtrasIz, ruedaAtrasDe;

    public float velocidadRotacion;

    private void Update()
    {
        ruedaFrenteIz.Rotate(Vector3.right * velocidadRotacion * Time.deltaTime);
        ruedaFrenteDe.Rotate(Vector3.right * velocidadRotacion * Time.deltaTime);
        ruedaAtrasIz.Rotate(Vector3.right * velocidadRotacion * Time.deltaTime);
        ruedaAtrasDe.Rotate(Vector3.right * velocidadRotacion * Time.deltaTime);
    }

}
