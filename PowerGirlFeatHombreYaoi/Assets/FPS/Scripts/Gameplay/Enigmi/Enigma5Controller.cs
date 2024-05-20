using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enigma5 : MonoBehaviour, IPointerClickHandler
{
    public List<GameObject> soluzione;
    public List<GameObject> posizioni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MuoviVaso();        
    }

     public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(eventData);
        GameObject gameObject = eventData.pointerCurrentRaycast.gameObject;
        Debug.Log("Clicked: " + gameObject.name);        
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;


    }
    public void MuoviVaso(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            
        }
    }
}
