using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorLimitSounds : MonoBehaviour
{
    public Sounds ScriptSound;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScriptSound.stopSounds();
            playSounds();
            //Debug.Log("Entro a OnTriggerEnter");
        }
    }

    public void playSounds()
    {
        GetComponent<AudioSource>().Play();
    }
}
