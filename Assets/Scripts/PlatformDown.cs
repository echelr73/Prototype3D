using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {


    }


}
