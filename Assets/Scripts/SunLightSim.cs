using UnityEngine;

public class SunLightSim : MonoBehaviour
{
    
    [SerializeField] public bool lightOn;

    [SerializeField] private Light lightBulb;

    [SerializeField] public BoxCollider lightCollision;
    
    // Start is called before the first frame update
    void Start()
    {
        lightOn = false;
        lightBulb = GetComponent<Light>();
        lightBulb.enabled = false;

        lightCollision = GetComponent<BoxCollider>();
        lightCollision.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       LightChecker();
    }
    
    private void LightChecker()
    {
        if (lightOn)
        {
            lightBulb.enabled = true;
            lightCollision.enabled = true;
        }

        else
        {
            lightBulb.enabled = false;
            lightCollision.enabled = false;
        }
    }

    public void LightSwitch()
    {
        lightOn = !lightOn;
    }
    
    void OnTriggerStay(Collider other)
    {
        var plant = other.GetComponent<Plant>();
        if (plant)
        {
            plant.AddSunlight();
        }
    }
    
}
