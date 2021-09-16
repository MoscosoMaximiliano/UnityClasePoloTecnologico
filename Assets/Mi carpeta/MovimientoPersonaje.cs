using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float velocidadPersonaje = 3f;
    public float fuerzaSalto = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Salto();    
        }
    }
    
    void Movimiento()
    {
        float movimiento = Input.GetAxis("Horizontal") * velocidadPersonaje;
        _rb.velocity = new Vector2(movimiento, _rb.velocity.y);
    }

    void Salto() 
    {
        _rb.velocity = new Vector2(_rb.velocity.x, fuerzaSalto);
    }
}
