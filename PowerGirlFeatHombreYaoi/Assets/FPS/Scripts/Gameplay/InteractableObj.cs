using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InteractableObj : MonoBehaviour , IInteractable
{
    public bool door;
    public Canvas canvas;
    public void Interact(){
        Debug.Log("Ciao");
        if(!canvas.IsUnityNull()){
            canvas.gameObject.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

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
        EscCanvas();
    }

    public void EscCanvas(){
        if(Input.GetButtonDown("Cancel")){
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canvas.gameObject.SetActive(false);                        
        }
    }
}
