using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeatherManager : MonoBehaviour
{
    public static Action OnWeatherChanged;

    public enum WeatherState
    {
        Sunny,
        Rainy

    };

    public WeatherState currentWeather;

    // Start is called before the first frame update

    private void OnEnable()
    {
        TimeManager.OnDayStageChanged += UpdateWeather;
    }

    private void OnDisable()
    {
        TimeManager.OnDayStageChanged -= UpdateWeather;
    }

    void Start()
    {
        currentWeather = (WeatherState)UnityEngine.Random.Range(0, 1);
    }

    private void UpdateWeather()
    {
        int coin = UnityEngine.Random.Range(0, 1);
        if (coin == 1)
        {
            WeatherState temp = (WeatherState)UnityEngine.Random.Range(0, 1);
            if (currentWeather == temp)
            {
                currentWeather = (WeatherState)UnityEngine.Random.Range(0, 1);
            }
            else
            {
                currentWeather = temp;
            }
            OnWeatherChanged?.Invoke();
        }
    }
}
 
