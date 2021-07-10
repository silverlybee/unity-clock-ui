using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    TimeManager tm;

    public RectTransform minuteHand;
    public RectTransform hourHand;

    const float hoursToDegrees = 360 / 12, minutesToDegrees = 360 / 60;

    // Start is called before the first frame update
    void Start()
    {
        tm = FindObjectOfType<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        hourHand.rotation = Quaternion.Euler(0,0, -tm.GetHour()*hoursToDegrees);
        minuteHand.rotation = Quaternion.Euler(0, 0, -tm.GetMinutes() * minutesToDegrees);
    }
}
