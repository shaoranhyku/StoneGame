using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour {
    // Array de GameObject donde sus componentes cero, uno y dos
    // van a ser los tres prefab Stone que hemos creado
    public GameObject[] stones = new GameObject[3];
    // Fuerza de torsión que vamos a aplicar en cada uno de los ejes para que
    // la piedra tenga rotación inicial al crearse
    public float torque = 5f;
    // Valores que vamos a tener como fuerza cuando lancemos las piedras
    // que será un valor aleatorio entre ambos valores
    public float minAntiGravity = 20f, maxAntiGravity = 40f;
    // Fuerza lateral con la que se lanzarán las piedras, un rango entre ambos valores
    public float minLateralForce = -15f, maxLateralForce = 15f;
    // Tiempo que vamos a tener que esperar entre el lanzamiendo de las piedras
    public float minTimeBetweenStones = 1f, maxTimeBetweeStones = 3f;
    // Posición X del lanzamiento de la piedra
    public float minX = -30f, maxX = 30f;
    // Posición Z del lanzamiento de la piedra
    public float minZ = -5f, maxZ = 5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
