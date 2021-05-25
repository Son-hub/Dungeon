using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
    [SerializeField]
    Weapon _weapon = null;
    float _rotSpeed = 50.0f;
    float pick = 5.0f;

    void Update()
    {
        if(this.tag != "Player")
        transform.Rotate(new Vector3(0, _rotSpeed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.tag);
            if (Input.GetKeyUp(KeyCode.F))
            {
                other.GetComponent<PlayerAttack>().Equip(_weapon);
                Destroy(this.gameObject);
            }
            else if (pick <= Time.deltaTime) return;
        }
    }
}
