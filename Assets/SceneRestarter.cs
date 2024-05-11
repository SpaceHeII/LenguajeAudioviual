using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestarter : MonoBehaviour
{
    void Update()
    {
        // Verificar si se presiona la tecla "R"
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reiniciar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
