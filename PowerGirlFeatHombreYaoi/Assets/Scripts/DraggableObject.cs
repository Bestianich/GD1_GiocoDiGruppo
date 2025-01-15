using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.UI;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class DraggableObject : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{    
    private Enigma7Controller controller;
    public Vector3 worldPosition;
    public Camera cameraZoom;
    private Vector3 originalPos;     
    private GameObject altroVaso;           
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<Enigma7Controller>();
    }

    // Update is called once per frame
    void Update()
    {
                
    }
         

    public void OnDrag(PointerEventData eventData)
    {
        var mousePos = Input.mousePosition;
        Ray ray = cameraZoom.ScreenPointToRay(mousePos);
        if(Physics.Raycast(ray, out var hitInfo)){
            worldPosition = hitInfo.point;

        }
        transform.position = new Vector3(worldPosition.x , originalPos.y , worldPosition.z);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPos = transform.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        for(int i = 0; i < controller.posizioni.Count; i++){
            Debug.Log(i + " " + Vector3.Distance(transform.position, controller.posizioni[i].transform.position));
            if(Vector3.Distance( controller.posizioni[i].transform.position , transform.position) < 0.5f){
                Debug.Log("AAAH" + controller.posizioni[i].name);
                altroVaso = controller.posizioni[i].transform.GetChild(0).gameObject;
                altroVaso.transform.position = transform.parent.position;
                altroVaso.transform.SetParent(transform.parent);                
                transform.position = new Vector3(controller.posizioni[i].transform.position.x, originalPos.y, controller.posizioni[i].transform.position.z -0.1f);
                transform.SetParent(controller.posizioni[i].transform);
                return;
            } 
        }        
        transform.position = originalPos;            
    }
}
