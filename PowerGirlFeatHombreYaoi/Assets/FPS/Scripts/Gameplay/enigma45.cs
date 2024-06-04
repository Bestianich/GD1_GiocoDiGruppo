using System.Collections;
using System.Collections.Generic;
using System.IO;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class enigma45 : MonoBehaviour
{

    public Collider tastierino;
    public List<UnityEngine.UI.Image> soluzione;
    public List<UnityEngine.UI.Image> inseriti;
    public TextMeshProUGUI testo;
    public GameObject porta;
    // Start is called before the first frame update
    void Start()
    {
                testo = gameObject.transform.GetChild(4).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
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
                    /*gameObject.transform.GetChild(4).gameObject.SetActive(false);
                    testo.text = "";
                    gameObject.transform.GetChild(2).gameObject.SetActive(true);
                    inseriti.Clear();*/
                    StartCoroutine(Errore());
                    return;
                }
            }
            StartCoroutine(Giusto());
            /*
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(2).gameObject.SetActive(false);
            porta.transform.Rotate(0, 90, 0);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            inseriti.Clear();*/
        }
    }

    IEnumerator Errore(){
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
        inseriti.Clear();
        yield return new WaitForSeconds(1f); 
        testo.text = "";        
        gameObject.transform.GetChild(4).gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    IEnumerator Giusto(){
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;        
        porta.transform.Rotate(0 , 90 , 0);
        tastierino.enabled = false;
        gameObject.SetActive(false); 

    }
    public void insertImage(GameObject image){
        testo.text += "#";
        inseriti.Add(image.GetComponent<UnityEngine.UI.Image>());
    }
    
}
