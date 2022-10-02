using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    public GameObject airplane;

    public Quat quat = new Quat(0, 0, 0, 1);

    public float speed = 0.01f;

    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("UpDown");
        float inputY = Input.GetAxis("LeftRight");
        float inputZ = Input.GetAxis("Roll");
        
        // Debug.Log(inputX + "," +inputY +","+ inputZ);

        Quat qx = new Quat(Mathf.Cos(speed * inputX / 2), 0, 0, Mathf.Sin(speed * inputX / 2));
        Quat qy = new Quat(Mathf.Cos(speed * inputY / 2), 0, Mathf.Sin(speed * inputY / 2), 0);
        Quat qz = new Quat(MathF.Cos(speed * inputZ / 2), Mathf.Sin(speed * inputZ / 2), 0, 0);

        quat = Quat.Multiply(qx, quat);
        quat = Quat.Multiply(qy, quat);
        quat = Quat.Multiply(qz, quat);

        airplane.transform.rotation = quat.ToUnityQuaternion();
    }
}
