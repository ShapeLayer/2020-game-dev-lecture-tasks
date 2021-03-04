using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRecordDisplayer : MonoBehaviour
{
    public Text SecondsNum;
    void Start()
    {
        SecondsNum.text = GameManager.instance.timeRecord.ToString("f0");
    }
    
}
