using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ewave_move : MonoBehaviour
{
    public float move_speed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= move_speed * Time.fixedDeltaTime;
        transform.position = pos;

        
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag.Equals ("Player"))
        {
            if (col.gameObject != null)
            {
                Destroy (col.gameObject);
                Destroy (gameObject);
            }
            
        }
    }
    
    
}
