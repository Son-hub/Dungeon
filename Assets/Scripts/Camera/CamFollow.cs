using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform _target;

    void Update()
    {
        this.transform.position = _target.position;
    }
}
