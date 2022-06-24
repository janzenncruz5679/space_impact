using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class collide_ship : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag.Equals ("Player"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            SceneManager.LoadScene("game_over");
            
        }
    }
}
