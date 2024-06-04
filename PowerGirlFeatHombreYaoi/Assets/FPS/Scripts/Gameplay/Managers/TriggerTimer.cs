using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTimer : MonoBehaviour
{
    public Timer timer;
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            timer.TimerOn = true;
        }
    }
}
