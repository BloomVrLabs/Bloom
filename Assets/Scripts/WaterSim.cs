using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSim : MonoBehaviour
{
    public ParticleSystem part;
    private List<ParticleCollisionEvent> _collisionEvents;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        _collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        int numCollisionEvents = part.GetCollisionEvents(other, _collisionEvents);
        
        int i = 0;

        while (i < numCollisionEvents)
        {
            if (other.GetComponent<Plant>())
            {
                other.GetComponent<Plant>().AddWater();
            }
            i++;
        }
    }
}
