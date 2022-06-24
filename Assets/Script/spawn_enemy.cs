using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn_enemy : MonoBehaviour{
    public float enemy_speed = 10.0f;
    private Rigidbody2D rb;
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-enemy_speed, 0);
    }
    void Update(){
        
    }
}

