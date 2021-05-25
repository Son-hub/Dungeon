using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    Dictionary<int, string> item = new Dictionary<int, string>();
    
    void Start()
    {
        item.Add(1, "Sword");
        item.Add(2, "Axe");
        item.Add(3, "Gun");
        item.Add(4, "Bow");

        item.Add(5, "Heal");
        item.Add(6, "Alldamage");
        item.Add(7, "Attackdelay");
        item.Add(8, "Attackpower");
    }

    void Update()
    {
    }
}
