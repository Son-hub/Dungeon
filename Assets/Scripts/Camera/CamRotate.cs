using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float _rotSpeed = 200.0f;

    float _mx = 0;
    float _my = 0;
    // Update is called once per frame
    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        _mx += mouse_X * _rotSpeed * Time.deltaTime;
        _my += mouse_Y * _rotSpeed * Time.deltaTime;

        _my = Mathf.Clamp(_my, -90.0f, 90.0f);

        this.transform.eulerAngles = new Vector3(-_my, _mx, 0);
    }
}
