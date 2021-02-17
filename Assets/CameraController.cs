using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public CinemachineFreeLook thirdPersonCamera;
    public Camera overheadCamera;
    void Start()
    {
        thirdPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
            overheadCamera.enabled = !overheadCamera.enabled;
        }
    }
}
