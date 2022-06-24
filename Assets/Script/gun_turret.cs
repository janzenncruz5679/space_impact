using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gun_turret : MonoBehaviour
{
    public Transform target;
    public float enemyAimSpeed=5.0f; 
    Quaternion newRotation;
    float orientTransform;
    float orientTarget;
    public static AudioSource boom;
    void Update () {
    orientTransform = transform.position.x;
    orientTarget = target.position.x;
    if (orientTransform > orientTarget) {
    newRotation = Quaternion.LookRotation (transform.position - target.position, -Vector3.up);
    }
    else {
    newRotation = Quaternion.LookRotation (transform.position - target.position,Vector3.up);
    }
    
    newRotation.x = 0.0f;
    newRotation.y = 0.0f;
    
    transform.rotation = Quaternion.Lerp (transform.rotation,newRotation,Time.deltaTime * enemyAimSpeed);


    }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Bullet"))
        {
        Destroy (col.gameObject);
        Destroy (gameObject);
        }
        Destroy (gameObject);
    }


}
