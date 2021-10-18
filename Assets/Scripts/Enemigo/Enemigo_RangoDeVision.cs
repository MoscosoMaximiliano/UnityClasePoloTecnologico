using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_RangoDeVision : MonoBehaviour
{

    Enemigo controller;

    void Awake()
    {
        controller = GetComponentInParent<Enemigo>();        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("Personaje")){
            controller._esPersonaje = true;
            controller._posicion = other.gameObject.transform;
        }
        

    }
    private void OnTriggerExit2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("Personaje")){
            controller._esPersonaje = false;
            controller._posicion = null;
        }
        
    }
}
