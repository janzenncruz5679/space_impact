using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class joystick_game : MonoBehaviour{
    public float movement_speed;
    public Rigidbody2D rb;
    private Vector2 move_direction;
    void Update(){
        process_input();
    }
    void FixedUpdate(){
        Move();
    }
    void process_input(){
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");

        move_direction = new Vector2(move_x, move_y);
    }
    void Move(){
        rb.velocity = new Vector2(move_direction.x * movement_speed, move_direction.y * movement_speed);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Enemy"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
        if (col.gameObject.tag.Equals ("Portal_1"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("Level_2");
        }
        
        if (col.gameObject.tag.Equals ("Portal_2"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("Level_3");
        }

        if (col.gameObject.tag.Equals ("Portal_3"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("Level_4");
        }

        if (col.gameObject.tag.Equals ("Portal_4"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("Level_5");
        }

        if (col.gameObject.tag.Equals ("Parchment"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("thankyou");
        }

    }
    //balak tanggalin
    /*private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals ("Enemy"))
        {
            Destroy (other.gameObject);
            Destroy (gameObject);
            
        }
    }*/

}
