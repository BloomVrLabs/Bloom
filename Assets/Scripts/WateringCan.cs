using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    [SerializeField] private Collider collider;

    [SerializeField] private GameObject liquid;
    
    [Range(0.0f, 1.0f)]
    [SerializeField] private float water;

    private Renderer rend;

    private void Start()
    {
        rend = liquid.GetComponent<Renderer>();
    }


    // Update is called once per frame
    void Update()
    {
        rend.material.SetFloat("_Fill", water);
    }

    public void decreaseWater()
    {
        if (water < 0)
        {
            water = 0;
        }
        else
        {
            water -= 0.001f;
        }
    }
    
    public void increaseWater()
    {
        if (water > 1)
        {
            water = 1;
        }
        else
        {
            water += 0.001f;
        }
    }
}
