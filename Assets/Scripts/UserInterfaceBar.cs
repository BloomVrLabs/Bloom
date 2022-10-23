using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceBar : MonoBehaviour
{
    public Slider slider;

    public void SetValue(float newValue)
    {
        slider.value = newValue;
    }
}
