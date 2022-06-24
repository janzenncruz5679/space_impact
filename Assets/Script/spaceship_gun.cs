using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spaceship_gun : MonoBehaviour
{
    public Transform gun_trajectory;
    public GameObject bullet_prefab;
    public static AudioSource gun_sound;
    

    // Update is called once per frame
    void Update()
    {
        gun_sound = GetComponent<AudioSource>();
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
            gun_sound.Play();
        }
    }
    public void shoot(){
        Instantiate(bullet_prefab, gun_trajectory.position, gun_trajectory.rotation);
    }

}
