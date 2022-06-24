using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shot_script : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float bullet_duration;
    
    void Start()
    {
        Invoke("DestroyProjectile", bullet_duration);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void DestroyProjectile(){
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
