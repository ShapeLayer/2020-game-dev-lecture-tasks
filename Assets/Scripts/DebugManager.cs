using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugManager : MonoBehaviour
{
    public Text isonDebugModeText;
    public void ChangeDebugMode()
    {
        print(GameManager.instance.isDebugMode);
        if (GameManager.instance.isDebugMode)
        {
            GameManager.instance.isDebugMode = false;
        }
        else
        {
            GameManager.instance.isDebugMode = true;
        }
        /*
        if (GameManager.instance.isDebugMode)
        {
            isonDebugModeText.text = "디버그 모드";
        } else
        {
            isonDebugModeText.text = "";
        }*/
    }
}
