using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float health;
    [Range(0.0f, 1.0f)]
    public float water;
    [Range(0.0f, 1.0f)]
    public float sunlight;

    public ScriptableObject plantData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
