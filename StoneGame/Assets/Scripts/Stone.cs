﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -30f)
        {
            Destroy(gameObject);
        }
	}

    private void OnMouseDown()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        GameManager.stonesDestroyed++;
        Destroy(gameObject);
    }

}
