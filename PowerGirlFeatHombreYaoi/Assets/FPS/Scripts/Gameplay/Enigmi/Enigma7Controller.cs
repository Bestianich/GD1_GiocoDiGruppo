using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine.UI;
using UnityEditor.UI;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Enigma7Controller : MonoBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public List<GameObject> soluzione;
    public List<GameObject> posizioni;
    public Vector3 worldPosition;
    public Camera cameraZoom;
    public GameObject button;
    private Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    
     public void OnPointerClick(PointerEventData eventData)
    {        
        Debug.Log(eventData);
        GameObject obj = eventData.pointerCurrentRaycast.gameObject;
        if(obj.Equals(button)){
            OnButtonPress();
        }
        Debug.Log("Clicked: " + gameObject.name);        
        //gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

    }    

    public void OnButtonPress(){
        Debug.Log("SMigler");
        for(int i = 0; i < soluzione.Count; i++){            
            if(!soluzione[i].Equals(posizioni[i].transform.GetChild(0).gameObject)){
                return;
            }
        }
        Debug.Log("Hai vinto!!");
    }


    public void OnDrag(PointerEventData eventData)
    {
       /* var mousePos = Input.mousePosition;
        Ray ray = cameraZoom.ScreenPointToRay(mousePos);
        if(Physics.Raycast(ray, out var hitInfo)){
            worldPosition = hitInfo.point;

        }
        transform.position = new Vector3(worldPosition.x , originalPos.y , worldPosition.z);
     */
    }

    public void OnBeginDrag(PointerEventData eventData)
    {        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //transform.position = originalPos;
    }

}
