using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class RotationPlayerUI
{
    public Transform UIrotation;
    public Transform CameraRot;

    public void GetRotation()
    {
        UIrotation.rotation = CameraRot.rotation;
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public RotationPlayerUI(Transform UIrotation, Transform CameraRot)
    {
        this.UIrotation = UIrotation;
        this.CameraRot = CameraRot;
    }
}
