using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public int puntos;
    public int vidas;

    public TextMeshProUGUI textoPuntos;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if(Instance != this)
            Destroy(this);
    }

    public void SumarPuntos(int variable) 
    {
        puntos += variable;
        textoPuntos.text = "Puntos: " + puntos;
    }
}
