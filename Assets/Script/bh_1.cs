using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bh_1 : MonoBehaviour
{
    [SerializeField] public AudioSource bh_sound;
    void Start()
    {
        bh_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bh_sound.Play();
    }
}
