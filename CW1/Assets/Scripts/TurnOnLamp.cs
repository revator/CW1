using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLamp : MonoBehaviour
{

    // Variables
    public GameObject lampLight;
    public Light directionalLight;

    // Use this for initialization
    void Start()
    {

        lampLight = GameObject.Find("LAt_Light");
        lampLight.SetActive(false);
        print("I OWORk");
    }

    // Update is called once per frame
    void Update()
    {
        Turnon();
    }

    void Turnon()
    {
        if (directionalLight.intensity <= 0.05f)
        {
            lampLight.SetActive(true);
        }
    }
}
