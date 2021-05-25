using UnityEngine;

//무기 메뉴 만들기 (파일이름, 메뉴선택 순서)
[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/MakeNewWeapon", order = 0)]
public class Weapon : ScriptableObject
{
    [SerializeField]
    AnimatorOverrideController _override = null;
    [SerializeField]
    GameObject _weapon = null;
    [SerializeField]
    float _damage = 5.0f;
    public float Damage { get{ return _damage; } }
    [SerializeField]
    float _range = 1.0f;
    public float Range { get { return _range; } }
    [SerializeField]
    bool _isrighthand = true;

    const string _weaponName = "Weapon";

    public void Spawn(Transform right, Transform left, Animator animator)
    {
        SpawnWeapon(right, left);
        if (_weapon != null)
        {
            Transform hand = null;
            hand = _isrighthand ? right : left;
            GameObject weapon = Instantiate(_weapon, hand);
            weapon.name = _weaponName;
        }
        if (_override != null)
        {
            animator.runtimeAnimatorController = _override;
        }
    }

    private void SpawnWeapon(Transform right, Transform left)
    {
        Transform old = right.Find(_weaponName);

        if (old == null)
        {
            old = left.Find(_weaponName);
        }

        if (old == null) return;

        Destroy(old.gameObject);
    }

}
