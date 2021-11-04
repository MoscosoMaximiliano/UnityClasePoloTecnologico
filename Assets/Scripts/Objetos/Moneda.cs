using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Objetos
{
    public class Moneda : MonoBehaviour
    {
        public int valorMoneda;
        public AudioSource _source;
        public AudioClip _clip;

        private void Start()
        {
            _source = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Personaje"))
            {
                GameController.Instance.SumarPuntos(valorMoneda);
                _source.PlayOneShot(_clip);


                //Desactivar el sprite y el box collider
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;


                Destroy(this.gameObject, _clip.length);
            }
        }
    }    
}

