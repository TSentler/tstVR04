using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public float timeLeft = 60f;

    bool timerActive = true;

    public TMP_Text timerText;

    void Update()
    {
        if (timerActive == false) 
            return;

        timeLeft -= Time.deltaTime;
        int time = Mathf.CeilToInt(timeLeft);
        timerText.text = "Time: " + time;

        if (time <= 0)
        {
            timerText.text = "Time: 0";
            timerActive = false;
            Debug.Log("Время вышло");
        }
    }
}
