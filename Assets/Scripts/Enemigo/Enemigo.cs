

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Rigidbody2D _rb;

    public GameObject _rangoDeVision;

    public Transform _posicion;

    public float velocidad = 0;

    public bool _esPersonaje;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if(_posicion != null) {
            Mover();
        }
    }

    void Mover() {
        Vector2 direccion = _posicion.position - transform.position;

        direccion = new Vector2(direccion.x, 0);

        _rb.velocity = direccion.normalized * velocidad;
    }
}
