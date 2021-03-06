﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public int amountStones = 20;


    // Permitir que se lancen piedras
    private bool enableStones = true;
    private Rigidbody rigidbody;

    // Use this for initialization
    void Start () {
        StartCoroutine(ThrowStones());
	}

    private IEnumerator ThrowStones()
    {
        yield return new WaitForSeconds(3);

        while (enableStones)
        {
            GameObject stone = Instantiate(stones[UnityEngine.Random.Range(0, stones.Length)]);
            stone.transform.position = new Vector3(UnityEngine.Random.Range(minX, maxX), -30, UnityEngine.Random.Range(minZ, maxZ));
            stone.transform.rotation = UnityEngine.Random.rotation;

            rigidbody = stone.GetComponent<Rigidbody>();

            rigidbody.AddTorque(Vector3.up * torque, ForceMode.Impulse);
            rigidbody.AddTorque(Vector3.right * torque, ForceMode.Impulse);
            rigidbody.AddTorque(Vector3.forward * torque, ForceMode.Impulse);

            rigidbody.AddForce(Vector3.up * UnityEngine.Random.Range(minAntiGravity, maxAntiGravity), ForceMode.Impulse);
            rigidbody.AddForce(Vector3.right * UnityEngine.Random.Range(minLateralForce, maxLateralForce), ForceMode.Impulse);

            GameManager.stonesThrown++;

            if (GameManager.stonesThrown == amountStones)
            {
                enableStones = false;
                yield return new WaitForSeconds(6f);
            }
            else
            {
                yield return new WaitForSeconds(UnityEngine.Random.Range(minTimeBetweenStones, maxTimeBetweeStones));
            }
        }
        SceneManager.LoadScene("Final");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
