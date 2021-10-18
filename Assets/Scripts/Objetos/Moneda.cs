using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Objetos
{
    public class Moneda : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
                Destroy(this.gameObject);
        }
    }    
}

