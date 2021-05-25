using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    CharacterController _cc;
    Animator _animator = null;
    public float _speed = 5;
    //public GameObject _hitEffect;
    public Slider _hpSlider;
    public int _hp = 0;
    int _maxHp = 100;
    float _yVelocity = 0.0f;
    float _gravity = -20.0f;

    void Start()
    {
        _hp = _maxHp;
        _cc = this.GetComponent<CharacterController>();
        _animator = this.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        _animator.SetFloat("Move", dir.magnitude);
        dir = Camera.main.transform.TransformDirection(dir);

        _cc.Move(dir * _speed * Time.deltaTime);

        _hpSlider.value = (float)_hp / (float)_maxHp;

        _yVelocity += _gravity * Time.deltaTime;
        dir.y = _yVelocity;
        _cc.Move(dir * _speed * Time.deltaTime);
    }
    

}
