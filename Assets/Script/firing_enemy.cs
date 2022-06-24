using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class firing_enemy : MonoBehaviour
{
    public float fire_speed= 10.0f;
    private Rigidbody2D rb;
    private Vector2 screen_bounds;
     public Transform bullet_enemy;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-fire_speed, 0);

    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Player"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
    }
}
