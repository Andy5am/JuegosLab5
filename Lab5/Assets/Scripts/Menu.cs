﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cambiarPantalla(int num)
    {
        SceneManager.LoadScene(num);
    }
    public void subirVolumen()
    {
        GetComponent<AudioSource>().volume += 0.1f;
    }
    public void bajarVolumen()
    {
        GetComponent<AudioSource>().volume-= 0.1f;
    }
}
