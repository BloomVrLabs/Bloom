using System;
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

    [SerializeField] private PlantStatsUI _plantUI;

    // Start is called before the first frame update
    void Start()
    {
        _currentStage = plantData.stages[1];
        plantModel = _currentStage.getModelObject();
        
        //instantiate model
        Instantiate(plantModel, transform.position, transform.rotation);

        _plantUI.healthBar.SetValue(health);
        _plantUI.waterBar.SetValue(water);
        _plantUI.sunBar.SetValue(sunlight);
    }

    private void Update()
    {
        _plantUI.healthBar.SetValue(health);
        _plantUI.waterBar.SetValue(water);
        _plantUI.sunBar.SetValue(sunlight);
    }

    public void AddHealth()
    {
        health += 0.1f;
    }
    public void RemoveHealth()
    {
        health -= 0.1f;
    }
    public void AddWater()
    {
        water += 0.1f;
    }
    public void RemoveWater()
    {
        water -= 0.1f;
    }
    public void AddSunlight()
    {
        sunlight += 0.1f;
    }
    public void RemoveSunlight()
    {
        sunlight -= 0.1f;
    }
    
    public void NextStage()
    {
        _currentStage = plantData.stages[plantData.stages.IndexOf(_currentStage) + 1];
    }
}
