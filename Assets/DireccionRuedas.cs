using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DireccionRuedas : MonoBehaviour
{
    public Transform ruedaFrenteIz, ruedaFrenteDe;

    private void Update()
    {

        ruedaFrenteDe.localEulerAngles = transform.localEulerAngles;
        ruedaFrenteIz.localEulerAngles = transform.localEulerAngles;
    }
}
