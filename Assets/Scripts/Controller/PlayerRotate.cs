using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float _rotSpeed = 200.0f;
    float _mx = 0;

    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X");
        _mx += mouse_X * _rotSpeed * Time.deltaTime;

        this.transform.eulerAngles = new Vector3(0, _mx, 0);
    }
}
