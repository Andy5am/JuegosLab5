using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float contador;
    public GameObject text;
    public AudioClip win;
    private float won;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("Enemy"))
                {
                    contador++;
                    won++;
                    Destroy(hitInfo.collider.gameObject);
                    text.GetComponent<Text>().text = contador.ToString();
                    if (contador == 5 && won == 5){
                        GetComponent<AudioSource>().PlayOneShot(win);
                        won++;
                    }
                }
            }
        }
    }
}
