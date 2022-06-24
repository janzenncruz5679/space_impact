using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody2D rb;
    public int hitpoints = 1;

    void Start(){
        rb.velocity = transform.right * speed;
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject != null )
        {
            if (col.gameObject.tag.Equals ("Enemy"))
            {
                Destroy (col.gameObject);
                Destroy (gameObject);
                
            }
            
        }
    
    }
    void OnTriggerEnter2D(Collider2D hit){
        boss_hp boss = hit.GetComponent<boss_hp>();
        if (boss != null)
        {
            boss.Take_dmg(hitpoints);
        }
        Destroy(gameObject);
    }
    /*void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Enemy"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
    }*/


}

