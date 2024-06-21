using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadInicioScene()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void LoadControlsScene()
    {
        SceneManager.LoadScene("Controls");
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Prototype3D");
    }
}
