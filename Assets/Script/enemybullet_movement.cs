using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemybullet_movement : MonoBehaviour
{
    public float enemy_speed;
    public Transform player;
    public Transform pointer;
    public Transform gun;
    public GameObject e_projectile;
    public float follow_player;
    private bool in_range;
    public float attack_range;
    public float shot_interval;
    private float time_shot;
    public static AudioSource boom;

    
    void Update()
    {
        boom = GetComponent<AudioSource>();
       
        Vector3 difference = player.position - gun.transform.position;
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        gun.transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);

        if (Vector2.Distance(transform.position, player.position) <= follow_player && Vector2.Distance(transform.position, player.position) > attack_range)
        {
            in_range = true;
        }
        else
        {
            in_range = false;
        }

        if (Vector2.Distance(transform.position, player.position) <= attack_range)
        {
           if (time_shot <= 0)
           {
               Instantiate(e_projectile, pointer.position, pointer.transform.rotation);
               time_shot = shot_interval;
               boom.Play();
           }
           else
           {
               time_shot -= Time.deltaTime;
           }
        }

    }

    void FixedUpdate() {
        if (in_range)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemy_speed * Time.deltaTime);
        }
        
    }
}
