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

    public enum GrowthStages
    {
        Seed,
        Seedling,
        Growing,
        FullyGrown,
        Flowered
    };
    
    public GrowthStages currentGrowthStage;
    

    // Start is called before the first frame update
    void Start()
    {
        // when the plant is initialized make sure it's a seed.
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnWaterPlantTrigger()
    {
        
    }
}
