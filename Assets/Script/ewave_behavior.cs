using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ewave_behavior : MonoBehaviour
{
    float center_y;
    public float wave = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        center_y = transform.position.y;
    }

    void FixedUpdate() {
        Vector2 pos = transform.position;
        float sin = Mathf.Sin(pos.x) * wave;
        pos.y = center_y + sin;

        transform.position = pos;
    }

    void OnCollisionEnter2D (Collision2D col)
    {
         if (col.gameObject.tag.Equals ("Bullet"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            
        }

        
    }
}
