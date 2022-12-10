using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SeasonManager : MonoBehaviour
{
    public static Action onSeasonChange;

    public enum SeasonState
    {
        Spring,
        Summer,
        Fall,
        Winter
    };

    public SeasonState currentSeason;

    public int dayCount;

    private void OnEnable()
    {
        TimeManager.OnDayStageChanged += UpdateCount;
        TimeManager.OnDayStageChanged += UpdateSeason;
    }

    private void OnDisable()
    {
        TimeManager.OnDayStageChanged -= UpdateSeason;
    }

    void Start()
    {
        currentSeason = (SeasonState)UnityEngine.Random.Range(0, 3);
        dayCount = 0;
    }

    private void UpdateCount()
    {
        dayCount += 1;
    }

    private void UpdateSeason()
    {
       
        if (dayCount == 30)
        {
            SeasonState temp = (SeasonState)UnityEngine.Random.Range(0, 3);
            if (currentSeason == temp)
            {
                currentSeason = (SeasonState)UnityEngine.Random.Range(0, 3);
            }
            else
            {
                currentSeason = temp;
            }
            dayCount = 0;
            onSeasonChange?.Invoke();
        }
    }
}
