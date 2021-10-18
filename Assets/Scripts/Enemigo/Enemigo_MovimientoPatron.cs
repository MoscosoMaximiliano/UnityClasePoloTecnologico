using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_MovimientoPatron : MonoBehaviour
{
    Enemigo _controller;
    public Transform[] puntosMovimiento;
    
    public bool _repetible = true;
    public float _duracionQuieto = 0.1f;

    public float toleranciaDistanciaPosicion = 0.5f;

    int _puntoActual = 0;

    private bool _courutineWorking = false;

    void Awake()
    {
        _controller = GetComponent<Enemigo>();
    }

    private void Update() 
    {
        if(!_controller._esPersonaje && puntosMovimiento.Length != 0)
        {
            Caminar();
        }
    }

    void Caminar() 
    {
        if(Vector2.Distance(transform.position, puntosMovimiento[_puntoActual].position) > toleranciaDistanciaPosicion && _puntoActual < puntosMovimiento.Length)
        {
            _controller._posicion = puntosMovimiento[_puntoActual];
        }
        else if(!_courutineWorking)
        {
            StartCoroutine(Esperar());
        }
    }

    IEnumerator Esperar()
    {
        _courutineWorking = true;
        yield return new WaitForSeconds(_duracionQuieto);
        
        _puntoActual++;

        if (_puntoActual >= puntosMovimiento.Length && _repetible)
            _puntoActual = 0;

        _courutineWorking = false;
    }


    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        if(puntosMovimiento.Length != 0){
            foreach (Transform posicion in puntosMovimiento)
            {
                Gizmos.DrawSphere(posicion.position, 0.2f);
            }
        }
    }
}
