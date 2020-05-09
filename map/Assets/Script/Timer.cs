using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float LimitTime = 91f;
    public Text TimeText;
    void Update()
    {
        transform.Translate(new Vector3(155, -64, 55));

        LimitTime -= Time.deltaTime;

        if (LimitTime >= 0)
        {
            if (LimitTime >= 60f)
            {
                int b = (int)LimitTime - 60;
                if (b < 10)
                    TimeText.text = "1 : " + "0" + b;
                else
                    TimeText.text = "1 : " + b;
            }
            else
            {
                int b = (int)LimitTime;
                if (b < 10)
                    TimeText.text = "0 : 0" + b;
                else
                    TimeText.text = "0 : " + b;
            }
        }

        else
        {
            TimeText.text = "시간 끝남";
            return;
        }
    }
}
