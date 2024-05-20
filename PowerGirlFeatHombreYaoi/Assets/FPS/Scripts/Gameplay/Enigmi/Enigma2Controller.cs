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
    public List<GameObject> sequenzaSoluzione;
    public List<GameObject> spritesCliccati;
    
    // Start is called before the first frame update
    void Start()
    {                
        spritesCliccati = new List<GameObject>();
        //Debug.Log(gameObject.name);        
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
        if(spritesCliccati.Count == 0){
            spritesCliccati.Add(gameObject);
        } else if (spritesCliccati.Count > 0){
            for(int i = 0; i < spritesCliccati.Count; i++){
                if(spritesCliccati[i].Equals(gameObject)){
                    return;
                }                
            }
            Debug.Log(gameObject.name);
            spritesCliccati.Add(gameObject);
        }        
    }

    public void button(){
        if(ControlloSoluzione()){
            Debug.Log("Bravo");
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
            gameObject.SetActive(false);    
        } else {
            Debug.Log("Scemo");
            for(int i = 0; i < spritesCliccati.Count; i++){                
                spritesCliccati[i].GetComponent<Image>().color = Color.white;
            }
            spritesCliccati = new List<GameObject>();
        }
    }

    public bool ControlloSoluzione(){
        for(int i = 0; i < spritesCliccati.Count; i++){
            if(!spritesCliccati[i].Equals(sequenzaSoluzione[i])){
                return false;
            }
        }
        return true;
    }
}
