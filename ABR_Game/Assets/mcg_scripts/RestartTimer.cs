using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapRestart : MonoBehaviour {

    public GameObject RestartTimer;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        if(LapTimeManager1.SecondCount <= 9)
        {
            SecDisplay.GetComponent<Text>().text = "0" + LapTimeManager1.SecondCount + ".";
        }
        else
        {
            SecDisplay.GetComponent<Text>().text = "" + LapTimeManager1.SecondCount + ".";

        }

        if (LapTimeManager1.MinuteCount <= 9)
        {
            MinDisplay.GetComponent<Text>().text = "0" + LapTimeManager1.MinuteCount + ".";
        }
        else
        {
            MinDisplay.GetComponent<Text>().text = "" + LapTimeManager1.MinuteCount + ".";

        }

        LapTimeManager1.MilliCount = 0;
        MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager1.MilliCount + ".";

        LapTimeManager1.MinuteCount = 0;
        LapTimeManager1.SecondCount = 0;
        

        RestartTimer.SetActive(true);
    }


}
