using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InteractableObj : MonoBehaviour , IInteractable
{
    //public bool zoom;
    public bool door;
    public Camera cameraZoom;
    public Canvas canvas; 
    public GameObject Player;   
    public void Interact(){
        Debug.Log("Ciao");
        if(!canvas.IsUnityNull()){
            canvas.gameObject.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        } else if (door) {
            gameObject.transform.Rotate(0 , 90 , 0);
            door = false;
        } else if (!cameraZoom.IsUnityNull()){
            Player.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            cameraZoom.gameObject.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
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
        if(Input.GetButtonDown("Cancel") && !canvas.IsUnityNull()){
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canvas.gameObject.SetActive(false);               
        } else if (Input.GetButtonDown("Cancel") && !cameraZoom.IsUnityNull()) {
            Player.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            cameraZoom.gameObject.SetActive(false);
        }

    }
}
