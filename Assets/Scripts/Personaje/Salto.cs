using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Salto : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float fuerzaSalto = 2f;
    public bool puedeSaltar = false;

    public AudioSource _source;
    public AudioClip audioSalto;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && puedeSaltar == true)
        {
            Saltar();    
        }
    }

    void Saltar() 
    {
        //_rb.AddForce(new Vector2(0, fuerzaSalto));
        _rb.velocity = new Vector2(_rb.velocity.x, fuerzaSalto);
        _source.PlayOneShot(audioSalto);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Suelo")
        {
            puedeSaltar = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Suelo")
        {
            puedeSaltar = false;
        }
    }
}
