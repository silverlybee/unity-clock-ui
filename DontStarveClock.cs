using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontStarveClock : MonoBehaviour
{
    TimeManager tm;

    public RectTransform hand;
    public Image nightBackground;

    const float hoursToDegrees = 360 / 24;

    float startRotation;

    // Start is called before the first frame update
    void Start()
    {
        tm = FindObjectOfType<TimeManager>();
        nightBackground.fillAmount = tm.nightDuration;
        startRotation = tm.sunriseHour * hoursToDegrees;
    }

    // Update is called once per frame
    void Update()
    {
        hand.rotation = Quaternion.Euler(0,0,startRotation-tm.GetHour()*hoursToDegrees);
    }
}
