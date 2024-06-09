using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Enigma3Controller : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public int ore;
    public int minuti;    
    public AudioSource audioSource;
    private bool vinto;

    void Start()
    {
        // Assicurati che le lancette siano inizializzate correttamente
        if (hourHand == null || minuteHand == null)
        {
            Debug.LogError("Assegna i riferimenti delle lancette nell'editor Unity");
            return;
        }        
    }

    void Update(){
            check();
    }

    public void check(){
        if(ore == 12 && minuti == 12 && !vinto){
            audioSource.Play();
            Debug.Log("Hai vinto!");
            vinto = true;
        }
    }

    public void RotatehourHands()
    {
        // Ruota le lancette di 30 gradi ad ogni click
        if(ore < 12){
            ore++;
        } else {
            ore = 1;
        }

        hourHand.Rotate(Vector3.back, 30f);
    }

    public void RotateminuteHand()
    {
        if(minuti < 12){
            minuti++;
        } else {
            minuti = 1;
        }
        minuteHand.Rotate(Vector3.back, 30f);
    }
}

