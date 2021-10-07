using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoDeVision : MonoBehaviour
{
    public bool dentroDelRango = false;
    public Transform posicionPersonaje;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Personaje"){
            dentroDelRango = true;
            posicionPersonaje = other.gameObject.transform;
        }
        

    }
    private void OnTriggerExit2D(Collider2D other) {
        
        if(other.gameObject.tag == "Personaje"){
            dentroDelRango = false;
            posicionPersonaje = null;
        }
        
    }
}
