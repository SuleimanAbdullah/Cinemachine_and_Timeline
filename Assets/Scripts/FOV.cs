using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FOV : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera[] _cams;

    private bool _isFirstCam;
    void Awake()
    {
        _isFirstCam = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (_isFirstCam == true)
            {
                _cams[1].Priority = 10;
                _cams[0].Priority = 11;
                _isFirstCam = false;
            }
            else
            {
                _cams[0].Priority = 10;
                _cams[1].Priority = 11;
                _isFirstCam = true;
            }
        }
    }
}
