using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _cameraAngle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cameraAngle.Priority = 11;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _cameraAngle.Priority = 10;
        }
    }
}
