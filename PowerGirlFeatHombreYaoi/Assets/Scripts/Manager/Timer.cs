using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public bool timeStop = false;
    public Text TimerText;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer();
    }

    IEnumerator countDown(){
        if(!TimerOn){
            TimerOn = true;
            while(TimeLeft > 0 && !timeStop){                                
                //Debug.Log("CiaoSTREf " + TimeLeft );
                yield return new WaitForSeconds(1.0f);
                TimeLeft--;
            }
        }
    }
    void updateTimer()
    {        

        float minutes = Mathf.FloorToInt(TimeLeft / 60);
        float seconds = Mathf.FloorToInt(TimeLeft % 60);

        TimerText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");

    }


    public void startTimer(){                
        StartCoroutine(countDown());
    }

    IEnumerator coloraScritta(){
        TimerText.color = Color.red;
        yield return new WaitForSeconds(1f);
        TimerText.color = Color.white;
    }

    public void TogliTempo()
    {
        StartCoroutine(coloraScritta());
        TimeLeft -=30f;
    }

}