using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorManager : MonoBehaviour
{
    public Transform MirrorCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PosY = new Vector3(transform.position.x, SpatialBridge.cameraService.position.y, transform.position.z);
        Vector3 side1 = SpatialBridge.cameraService.position - PosY;
        Vector3 side2 = transform.forward;
        float angle = Vector3.SignedAngle(side1, side2, Vector3.up);

        MirrorCam.localEulerAngles = new Vector3(0,angle,0);
    }
}
