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

public class Enigma2Controller : MonoBehaviour, IPointerClickHandler
{    
    public Material glowEffect;
    public List<int> sequenzaSoluzione;

    void Awake(){
        sequenzaSoluzione = new List<int>(6);
    }
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
        GameObject gameObject = eventData.pointerCurrentRaycast.gameObject;
        Debug.Log("Clicked: " + gameObject.name);        
        gameObject.GetComponent<Image>().color = Color.red;
        //eventData.pointerCurrentRaycast.gameObject.
    }
}
