using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorLimit : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
