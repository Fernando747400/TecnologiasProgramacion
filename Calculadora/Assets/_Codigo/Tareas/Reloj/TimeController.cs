using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using System;
using UnityEngine;


public class TimeController : MonoBehaviour
{
    private Stopwatch stopwatch = new Stopwatch();
    private bool isEditing;
    private bool isRealTime;
    private bool isActive;
    private bool isValid;
    private int someHours;
    private int someMinutes;
    private int someSeconds;
    private int i;
    private Time customTime;
    [Header ("Input Fields")]
    [SerializeField] InputField hoursInputField;
    [SerializeField] InputField minutesInputField;
    [SerializeField] InputField secondsInputField;
    [SerializeField] Text timeText;
    [Header("Canvas")]
    [SerializeField] CanvasGroup editorCanvas;
    [SerializeField] CanvasGroup displayCanvas;


    void Start()
    {
        if (hoursInputField == null) hoursInputField = GetComponent<InputField>();
        if (minutesInputField == null) minutesInputField = GetComponent<InputField>();
        if (secondsInputField == null) secondsInputField = GetComponent<InputField>();
        isEditing = true;
        isRealTime = false;
        isActive = false;
    }


    void Update()
    {
        calculateTime();
        drawTime();
    }

    void checkActiveCanvas()
    {
        if (isEditing)
        {
            editorCanvas.alpha = 1;
            editorCanvas.interactable = true;
            editorCanvas.blocksRaycasts = true;
            displayCanvas.alpha = 0;
            displayCanvas.interactable = false;
            displayCanvas.blocksRaycasts = false;
        } else
        {
            editorCanvas.alpha = 0;
            editorCanvas.interactable = false;
            editorCanvas.blocksRaycasts = false;
            displayCanvas.alpha = 1;
            displayCanvas.interactable = true;
            displayCanvas.blocksRaycasts = true;
        }

    }

    void startTimer()
    {
        stopwatch.Reset();
        isActive = true;
        isEditing = false;
        checkActiveCanvas();
        i = 1;
        stopwatch.Start();
    }

    public void stopTimer()
    {
        isEditing = true;
        stopwatch.Stop();
        isActive = false;
        isRealTime = false;
        checkActiveCanvas();
    }

     bool isValidInput()
    {
        int.TryParse(hoursInputField.text, out someHours);
        int.TryParse(minutesInputField.text, out someMinutes);
        int.TryParse(secondsInputField.text, out someSeconds);

        if (someHours >= 0 && someHours <= 23)
        {
            isValid = true;
        }
        else
        {
            UnityEngine.Debug.Log("El formato de horas está fuera del rango");
            return isValid = false;
        }


        if (someMinutes >= 0 && someMinutes <= 59)
        {
            isValid = true;
        }
        else
        {
            UnityEngine.Debug.Log("El formato de minutos está fuera del rango");
            return isValid = false;
        }


        if (someSeconds >= 0 && someSeconds <= 59)
        {
            isValid = true;
        }
        else
        {
            UnityEngine.Debug.Log("El formato de segundos está fuera del rango");
            return isValid = false;
        }

        return isValid;
    }

    void buildTime()
    {
        customTime = new Time(someHours, someMinutes, someSeconds);
    }

    public void realTime()
    {
        isRealTime = true;
    }

    void drawTime()
    {
        if (isActive && !isRealTime)
        {
            timeText.text = customTime.getTime();
        }
        if (isActive && isRealTime)
        {
            timeText.text = timeText.text = DateTime.Now.ToString("HH:mm:ss");
        }
        
    }

    public void initializeTimer()
    {
        if (isValidInput())
        {
            buildTime();
            startTimer();
        }
    }

    void calculateTime()
    {
        if (isActive)
        {
            if (stopwatch.ElapsedMilliseconds >= (i * 1000))
            {
                i++;
                customTime.Second = customTime.Second +1;
            }

            if (customTime.Second >= 60)
            {
                customTime.Minute = customTime.Minute + 1;
                customTime.Second = 0;
            }

            if (customTime.Minute >= 60)
            {
                customTime.Hour = customTime.Hour + 1;
                customTime.Minute = 0;
            }

            if (customTime.Hour >= 24)
            {
                customTime.Hour = 0;
            }
        }
    }
}
