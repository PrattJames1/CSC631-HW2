using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource oof;

    void Start()
    {
        oof = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter()
    {
        Debug.Log("collision!");
        oof.Play();

    }
}
