using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentageManager : MonoBehaviour
{
    public float maximumYPos = 0f;
    public GameObject Player;
    public double percentage;
    public Text ProcessValue;

    // Start is called before the first frame update
    void Start()
    {
        percentage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        double percentageNative = Player.transform.localPosition.y / maximumYPos * 100;
        percentage = Math.Round(percentageNative, 0);
        ProcessValue.text = $"{percentage}%";
    }
}
