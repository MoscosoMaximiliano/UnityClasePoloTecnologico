using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accionar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D objeto) {
        if(objeto.gameObject.name == "Pepito")
        {
            objeto.GetComponent<SpriteRenderer>().color = Color.white;    
        }
    }
}
