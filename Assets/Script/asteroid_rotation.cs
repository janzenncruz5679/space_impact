using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_rotation : MonoBehaviour
{
    private float rot_z;
    public float rotation_speed;
    public bool clockwise_rot;
    void Update()
    {
        if (clockwise_rot == false)
        {
            rot_z += Time.deltaTime * rotation_speed;
        }
        else
        {
            rot_z += -Time.deltaTime * rotation_speed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rot_z);
    }
}
