using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class enemies : MonoBehaviour
{
    public float enemy_speed= 10.0f;
    private Rigidbody2D rb;
    private Vector2 screen_bounds;
    
    
    void Start()
    {
        enemy_movement();

    }

    void enemy_movement(){
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-enemy_speed, 0);
    }
    
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Bullet"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            
        }
        
        if (col.gameObject.tag.Equals ("Player"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);

            
        }
        
    }

}
