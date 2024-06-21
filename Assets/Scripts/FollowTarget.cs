using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public GameObject player;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        private void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
    }
}
