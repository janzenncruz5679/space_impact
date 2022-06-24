using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss_movement : MonoBehaviour
{
    public float speed = 0.8f;
    public float range = 3;
    
    float start_y;
    private int direction = 1;

    void Start()
    {
        start_y = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * direction);
        if (transform.position.y < start_y || transform.position.y > start_y + range)
        {
            direction *= -1;
        }
    }
}
