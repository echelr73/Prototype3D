using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSave : MonoBehaviour
{
    private GameObject[] pd;
    private void Start()
    {
        pd = GameObject.FindGameObjectsWithTag("PlatformDown");
    }

    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("PlatformAutoSave"))
        {
            PositionManager.platformName = hit.gameObject.name;
        }
        else if (hit.collider.CompareTag("PlatformDown"))
        {
            print("Entro al platform");
            StartCoroutine(platformFall());
        }
    }

    IEnumerator platformFall()
    {
        yield return new WaitForSeconds(3);
        rb.useGravity = true;
        print("Se activo el contador");
    }
}
