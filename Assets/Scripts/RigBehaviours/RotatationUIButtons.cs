using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class RotationUIButtons
{
    public Transform UIrotation;
    public Transform CameraRot;

    public void GetRotation()
    {
        UIrotation.rotation = CameraRot.rotation;
        //UIrotation.LookAt(CameraRot);

        /*Vector3 relativePos = CameraRot.position - UIrotation.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        UIrotation.rotation = rotation;*/
  
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public  RotationUIButtons(Transform UIrotation, Transform CameraRot)
    {
        this.UIrotation = UIrotation;
        this.CameraRot = CameraRot;
    }
}
