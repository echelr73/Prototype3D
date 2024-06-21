using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {       
            if (SceneManager.GetActiveScene().name == "Controls")
            {
                SceneManager.LoadScene("Inicio");
            }
            else
            {
                Application.Quit();
            }
        }
    }
}
