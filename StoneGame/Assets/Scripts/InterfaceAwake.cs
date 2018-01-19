﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.stonesThrown = 0;
        GameManager.stonesDestroyed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        SceneManager.LoadScene("StoneGame");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
