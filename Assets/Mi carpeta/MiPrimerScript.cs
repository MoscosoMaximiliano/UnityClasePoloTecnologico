using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    private int numero = 3;
    private float numeroS = 3.3f;
    private float suma = numero + numeroS;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(suma);
    }
}
