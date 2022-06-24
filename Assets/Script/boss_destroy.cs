using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss_destroy : MonoBehaviour
{
    public int hitpoints = 1;
    void OnTriggerEnter2D(Collider2D hit){
        boss_hp boss = hit.GetComponent<boss_hp>();
        if (boss != null)
        {
            boss.Take_dmg(hitpoints);
        }
    }

}
