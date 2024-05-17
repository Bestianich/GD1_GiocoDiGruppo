using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractableObj : MonoBehaviour , IInteractable
{
    public bool door;
    public Canvas canvas;
    public void Interact(){
        Debug.Log("Ciao");
        if(!canvas.IsUnityNull()){
            canvas.gameObject.SetActive(true);
        } else if (door) {
            gameObject.transform.Rotate(0 , 90 , 0);
            door = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
