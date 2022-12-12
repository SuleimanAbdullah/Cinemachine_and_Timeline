using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FOV : MonoBehaviour
{
    private CinemachineVirtualCamera _cam;

    [SerializeField]
    private GameObject _target1;
    [SerializeField]
    private GameObject _target2;

    private bool _isFirstTarget;
    void Awake()
    {
        _cam = GetComponent<CinemachineVirtualCamera>();
        _isFirstTarget = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_isFirstTarget == true)
            {
                _cam.LookAt = _target1.transform;
                _isFirstTarget = false;
            }
            else
            {
                _cam.LookAt = _target2.transform;
                _isFirstTarget = true;
            }
        }
    }
}
