using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantScriptableObject", menuName = "ScriptableObject/Plant")]
public class PlantScriptableObject : ScriptableObject
{
    public string plantName;
    [SerializeField]
    public List<StageScriptableObject> stages;
}
