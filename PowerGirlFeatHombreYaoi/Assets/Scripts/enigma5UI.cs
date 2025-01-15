using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class enigma5UI : MonoBehaviour, IPointerClickHandler
{
    public GameObject fessura;
    public GameObject player;
    public List<GameObject> immagini;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < gameObject.transform.childCount; i++){
            immagini.Add(gameObject.transform.GetChild(i).gameObject);
        }
        for(int i = 0; i < immagini.Count;i++){            
            Debug.Log(player.GetComponent<Inventario>().cubi[i].name);
            for(int j = 0; j < immagini.Count;j++){
                if(player.GetComponent<Inventario>().cubi[i].name.Equals(immagini[j].name)){                
                    immagini[j].SetActive(true);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject gameObject = eventData.pointerCurrentRaycast.gameObject;
        Debug.Log("Clicked: " + gameObject.name);        
        //gameObject.GetComponent<RawImage>().color = Color.red;
        gameObject.SetActive(false); 
        for(int i = 0; i < immagini.Count;i++){
            if(gameObject.name.Equals(player.GetComponent<Inventario>().cubi[i].name)){                            
                fessura.GetComponent<MeshRenderer>().enabled = true;
                fessura.GetComponent<MeshRenderer>().material = player.GetComponent<Inventario>().cubi[i].GetComponent<MeshRenderer>().material;
            }
        }
    }    
}
