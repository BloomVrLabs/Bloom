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

    [SerializeField] private PlantScriptableObject plantData;
    private StageScriptableObject _currentStage;
    
    [SerializeField] private GameObject plantModel;
    [SerializeField] private Transform plantSpawn;
    [SerializeField] private new Collider collider; 

    [SerializeField] private PlantStatsUI plantUI;

    private GameObject _plant;

    // Start is called before the first frame update
    void Start()
    {
        _currentStage = plantData.stages[1];
        plantModel = _currentStage.getModelObject();
        
        //instantiate model
        var parent = transform;
        _plant = Instantiate(plantModel, plantSpawn.position, parent.rotation, parent);
        _plant.transform.parent = this.transform;

        plantUI.healthBar.SetValue(health);
        plantUI.waterBar.SetValue(water);
        plantUI.sunBar.SetValue(sunlight);
    }

    private void Update()
    {
        //Decrease stats each frame
        RemoveSunlight();
        RemoveWater();

        //Make Sure the stats dont go over max!
        if (water > 1f) { water = 1f; }
        if (sunlight > 1f) { sunlight = 1f; }
        
        // make sure they dont go under 0
        if (water < 0f) { water = 0f; }
        if (sunlight < 0f) { sunlight = 0f; }

        //Update UI & Calculate Plant Health
        plantUI.healthBar.SetValue(CalculateHealth());
        plantUI.waterBar.SetValue(water);
        plantUI.sunBar.SetValue(sunlight);
        
        //change stage
        if (health > 0.75f)
        {
            NextStage();
        }
        
    }

    private float CalculateHealth()
    {
        health = (water + sunlight) / 2;
        return health;
    }
    public void AddWater()
    {
        water += 0.005f;
    }
    private void RemoveWater()
    {
        water -= 0.00025f;
    }
    public void AddSunlight()
    {
        sunlight += 0.005f;
    }
    private void RemoveSunlight()
    {
        sunlight -= 0.00025f;
    }
    
    private void NextStage()
    {
        water = 0.25f;
        sunlight = 0.25f;
        
        _currentStage = plantData.stages[plantData.stages.IndexOf(_currentStage) + 1];

        //change model
        plantModel = _currentStage.getModelObject();


    }

    private void OnWaterPlantTrigger()
    {
        
    }
}
