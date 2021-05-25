using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float _findDistance = 5.0f;
    public float _attackDistacne = 2.0f;
    public float _moveSpeed = 4.0f;
    public float _moveDistance = 70.0f;

    GameObject _player;
    CharacterController _cc;
    Vector3 _originPos;

    public int _maxHp;
    public int _hp;

    NavMeshAgent _agent;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _cc = this.GetComponent<CharacterController>();
        _originPos = this.transform.position;
        _hp = _maxHp;
        _agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        _agent.SetDestination(_player.transform.position);
    }

    public void Attack()
    {
       // if(Vector3.Distance(this.transform.position, _player.position) > _attackDistacne)
        {
            
        }
    }
}
