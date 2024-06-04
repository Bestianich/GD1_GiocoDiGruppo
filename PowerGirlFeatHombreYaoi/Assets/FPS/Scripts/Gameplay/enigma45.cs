using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class enigma45 : MonoBehaviour
{

    public List<UnityEngine.UI.Image> soluzione;
    public List<UnityEngine.UI.Image> inseriti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkSoluzione();
    }
    public void checkSoluzione(){
        if(inseriti.Count == soluzione.Count){
            for(int i = 0; i < soluzione.Count; i++){
                if(!inseriti[i].Equals(soluzione[i])){
                    gameObject.transform.GetChild(4).gameObject.SetActive(false);
                    gameObject.transform.GetChild(2).gameObject.SetActive(true);
                    return;
                }
            }
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
    public void insertImage(GameObject image){
        inseriti.Add(image.GetComponent<UnityEngine.UI.Image>());
    }
    
}
