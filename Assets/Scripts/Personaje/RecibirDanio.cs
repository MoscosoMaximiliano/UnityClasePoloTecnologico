using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RecibirDanio : MonoBehaviour
{
    public AudioSource _source;
    public AudioClip _clip;
    
    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Enemigo")
        {
            _source.PlayOneShot(_clip);
        }
    }
}
