using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using Unity.FPS.Gameplay;

public class insertEnigma5 : MonoBehaviour
{
    public Canvas canvas;
    //public float far;
    public PlayerCharacterController player;
    public Camera CameraPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EscCanvas();                
    }

    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0) && Vector3.Distance(player.transform.position , gameObject.transform.position) < CameraPlayer.GetComponent<Interactor>().InteractRange ){            
            canvas.gameObject.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            canvas.gameObject.SetActive(true);                       
            CameraPlayer.GetComponent<Interactor>().InteractRange = 0;; 
        }
    }

    public void EscCanvas(){
        if(Input.GetButtonDown("Cancel") && !canvas.IsUnityNull()){
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            canvas.gameObject.SetActive(false);                   
            CameraPlayer.GetComponent<Interactor>().InteractRange = 2;
        }
    }
}
