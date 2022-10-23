using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StageScriptableObject", menuName = "ScriptableObject/Stage")]
public class StageScriptableObject : ScriptableObject
{
    public string stageName;
    public float healthThreshold;
    public float neededWater;
    public float neededSunlight;
    public GameObject model;

    public GameObject getModelObject()
    {
        return model;
    }
}
