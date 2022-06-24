using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class e_bullet : MonoBehaviour
{
    public float speed_bullet;
    public float lifetime;
    void Start()
    {
        Invoke("DestroyProjectile", lifetime);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed_bullet * Time.deltaTime);
    }

    public void DestroyProjectile(){
        Destroy(gameObject);
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
