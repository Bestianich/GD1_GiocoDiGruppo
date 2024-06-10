using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCondition : MonoBehaviour
{
    public Canvas canvas;
    public Timer timer;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        StartCoroutine(win());
    }

    IEnumerator win(){
        yield return new WaitForSeconds(5f);
        canvas.gameObject.SetActive(true);
        timer.TimerText.color = Color.green;
        timer.timeStop = true;
    }
}
