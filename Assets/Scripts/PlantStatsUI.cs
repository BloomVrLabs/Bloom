using System;
using UnityEngine;
using UnityEngine.UI;

public class PlantStatsUI : MonoBehaviour
{
    public UserInterfaceBar healthBar;
    public UserInterfaceBar waterBar;
    public UserInterfaceBar sunBar;

    public Transform rayOrigin;


    public void Update()
    {
        
        RaycastHit hit;
        
        if (Physics.Raycast(rayOrigin.position, rayOrigin.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(rayOrigin.position, rayOrigin.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        else
        {
            Debug.DrawRay(rayOrigin.position, rayOrigin.TransformDirection(Vector3.forward) * 1000, Color.white);
        }
    }
}
