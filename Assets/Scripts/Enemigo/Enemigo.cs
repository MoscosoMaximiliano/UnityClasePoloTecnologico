

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Rigidbody2D _rb;

    public GameObject _rangoDeVision;
    private RangoDeVision RDV; 

    public float velocidad = 0;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
        RDV = _rangoDeVision.GetComponent<RangoDeVision>();
    }

    private void Update() {
        if(RDV.dentroDelRango){
            Mover();
        }
    }

    void Mover() {
        Vector2 direccion = RDV.posicionPersonaje.position - transform.position;
        Debug.Log(direccion);

        _rb.velocity = direccion * velocidad;
    }
}
