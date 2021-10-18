using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float velocidadPersonaje = 3f;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Movimiento();
    }
    
    void Movimiento()
    {
        float movimiento = Input.GetAxis("Horizontal") * velocidadPersonaje;
        _rb.velocity = new Vector2(movimiento, _rb.velocity.y);
    }
}
