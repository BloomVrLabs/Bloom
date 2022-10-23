using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{

    public static GameEvents currrent;

    private void Awake()
    {
        currrent = this;
    }

    
}
