using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{

    public static Action OnMinuteChanged;
    public static Action OnHourChanged;
    public static Action OnDayStageChanged;

    public static int Minute { get; private set; }

    public static int Hour { get; private set; }

    private float minuteToRealTime = 0.01f;

    private float timer;

    public enum DayStage
    {
        Morning,
        Afternoon,
        Evening,
        Night
        
    };

    private static DayStage DayStageNext(DayStage dayStage)
    {
        switch (dayStage)
        {
            case DayStage.Morning:
                return DayStage.Afternoon;
            case DayStage.Afternoon:
                return DayStage.Evening;
            case DayStage.Evening:
                return DayStage.Night;
            case DayStage.Night:
                return DayStage.Morning;
            default:
                return DayStage.Morning;
        }
    }

    public DayStage currentGrowthStage;

    // Start is called before the first frame update
    void Start()
    {
        Minute = 0;
        Hour = 0;
        currentGrowthStage = DayStage.Morning;
        timer = minuteToRealTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Minute++;
            OnMinuteChanged?.Invoke();

            if(Minute >= 60)
            {
                Hour++;
                OnHourChanged?.Invoke();
                if(Hour % 5 == 0)
                {
                    currentGrowthStage = DayStageNext(currentGrowthStage);
                    OnDayStageChanged?.Invoke();
                }
                Minute = 0;
            }
            timer = minuteToRealTime;
        }
    }
}
