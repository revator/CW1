using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLamp : MonoBehaviour
{

    // Variables
    public GameObject[] lampLight;
    public Light directionalLight;

    // Use this for initialization
    void Start()
    {
        foreach (GameObject lampLight in lampLight)
        {
            lampLight.SetActive(false);
        }
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
            foreach(GameObject lampLight in lampLight)
            {
                lampLight.SetActive(true);
            }
        }
    }
}
