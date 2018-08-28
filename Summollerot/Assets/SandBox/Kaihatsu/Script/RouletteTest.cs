using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RouletteTest : MonoBehaviour
{

    public Transform roulette;
    public GameObject stopBtn;
    public GameObject startBtn;
    public Text resultText;

    private int[] sizeList;
    private float nowSpeed = 0;
    private float MAX_SPEED = 360f;
    private bool isStart = false;
    private bool isStop = false;
    private readonly string[] RESULT_COLOR = new string[] { "ピンク", "黄色", "紫", "緑", "水色", "赤" };

    void Awake()
    {
        stopBtn.SetActive(false);
        resultText.text = "";
    }

    public void RotateStart()
    {
        resultText.text = "";
        isStart = true;
        stopBtn.SetActive(false);
        startBtn.SetActive(false);
    }

    void Update()
    {
        if (isStart)
        {
            if (!isStop)
            {
                if (nowSpeed < MAX_SPEED)
                {
                    nowSpeed += 5f;
                }
                else
                {
                    stopBtn.SetActive(true);
                }
            }
            else
            {
                nowSpeed -= 5f;
            }

            roulette.localEulerAngles = new Vector3(0, 0, roulette.localEulerAngles.z + nowSpeed * -Time.deltaTime);

            if (nowSpeed <= 0)
            {
                isStart = false;
                isStop = false;
                startBtn.SetActive(true);
                string color = RESULT_COLOR[Mathf.FloorToInt((roulette.localEulerAngles.z / 60))];
                Debug.LogWarning(roulette.localEulerAngles.z + " : " + (roulette.localEulerAngles.z / 60));
                resultText.text = color + "が当たりました";
            }
        }
    }

    public void Stop()
    {
        isStop = true;
        stopBtn.SetActive(false);
    }
}