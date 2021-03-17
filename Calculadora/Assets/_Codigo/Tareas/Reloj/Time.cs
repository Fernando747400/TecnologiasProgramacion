using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time 
{
    private int hour;
    private int minute;
    private int second;
   public Time(int aHour, int aMinute, int aSecond)
    {
        hour = aHour;
        minute = aMinute;
        second = aSecond;
    }

    public int Hour
    {
        set { hour = value; }
        get { return hour; }
    }

    public int Minute
    {
        set { minute = value; }
        get { return minute; }
    }

    public int Second
    {
        set { second = value; }
        get { return  second; }
    }

    public void setTime(int aHour, int aMinute, int aSecond)
    {
        Hour = aHour;
        Minute = aMinute;
        Second = aSecond;
    }

    public string getTime()
    {
        string temporalHour;
        string temporalMinute;
        string temporalSecond;

        if (this.hour < 10)
        {
            temporalHour = "0" + this.hour;
        }
        else temporalHour = this.hour.ToString();

        if (this.minute < 10)
        {
            temporalMinute = "0" + this.minute;
        }
        else temporalMinute = this.minute.ToString();

        if (this.second < 10)
        {
            temporalSecond = "0" + this.second;
        }
        else temporalSecond = this.second.ToString();

        string aTime = temporalHour + ":" + temporalMinute + ":" + temporalSecond;

        return aTime;
    }

}
