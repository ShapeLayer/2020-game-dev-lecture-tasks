using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public float TimeRecordedInstance;
    public bool isClearStage = false;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (!isClearStage)
        {
            TimeRecordedInstance += Time.deltaTime;
        }
    }
}
