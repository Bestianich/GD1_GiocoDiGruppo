using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Enigma3Controller : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;

    void Start()
    {
        // Assicurati che le lancette siano inizializzate correttamente
        if (hourHand == null || minuteHand == null)
        {
            Debug.LogError("Assegna i riferimenti delle lancette nell'editor Unity");
            return;
        }
    }

    public void RotatehourHands()
    {
        // Ruota le lancette di 30 gradi ad ogni click
        hourHand.Rotate(Vector3.back, 30f);
    }

    public void RotateminuteHand()
    {
        minuteHand.Rotate(Vector3.back, 30f);
    }
}

