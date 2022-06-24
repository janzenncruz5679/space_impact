using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class follow_noshot : MonoBehaviour
{
    
    public float enemy_speed;
    public GameObject player;
    private float distance;
    public float distance_between;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       distance = Vector2.Distance(transform.position, player.transform.position);
       Vector2 direction = player.transform.position - transform.position;
       direction.Normalize();
       float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

       if (distance < distance_between)
       {
           transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemy_speed * Time.deltaTime);
           transform.rotation = Quaternion.Euler(Vector3.forward * angle);
       }
    }
    
    
}
