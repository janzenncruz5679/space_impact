using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boss_hp : MonoBehaviour
{
    public int health = 10;
    public GameObject death_effect;
    
    
    public void Take_dmg(int damage){
        health -= damage;
        if (health <= 0)
        {
            Die();
            //scene manager
        }
    }
    void Die(){
         Instantiate(death_effect,transform.position, Quaternion.identity);
         Destroy(gameObject);
     }
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag.Equals ("Player"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("game_over");
        }
         
    }
    
    
    
}
