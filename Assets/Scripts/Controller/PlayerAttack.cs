using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    float _attackDelay = 1.5f;
    float _sinceLastAttack = 0.0f;

    Animator _animator;

    [SerializeField]
    Transform _rightweaponTrans = null;
    [SerializeField]
    Transform _leftweaponTrans = null;
    [SerializeField]
    Weapon _initweapon = null;
    Weapon _currentweapon = null;

    void Start()
    {
        _animator = GetComponent<Animator>();
        Equip(_initweapon);
    }

    public void Equip(Weapon weapon)
    {
        _currentweapon = weapon;
        weapon.Spawn(_rightweaponTrans, _leftweaponTrans, _animator);
    }
    
    void Update()
    {
        _sinceLastAttack += Time.deltaTime;
        Attack();
    }

    private void Attack()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.C))
        {
            _animator.SetTrigger("Attack1");
            _animator.SetTrigger("Attack2");
            _animator.SetTrigger("StopAttack");
            if (_attackDelay <= _sinceLastAttack)
            {
                _sinceLastAttack = 0.0f;
                _animator.ResetTrigger("Attack1");
                _animator.ResetTrigger("Attack2");
                _animator.ResetTrigger("StopAttack");
            }
        }
    }

    private void Hit()
    {
        /*if(_currentweapon.HasProjectile)
        {
            _currentweapon.LacunchProjectile(_rightweaponTrans, _leftweaponTrans, _target);
            return;
        }*/

        //_target.Damage(_currentweapon.Damage);
    }
}
