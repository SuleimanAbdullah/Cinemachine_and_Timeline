using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private CinemachineImpulseSource _source;

    public void Start()
    {
        _source = GetComponent<CinemachineImpulseSource>();
    }

    public void Shake()
    {
        _source.GenerateImpulse();
    }
}
