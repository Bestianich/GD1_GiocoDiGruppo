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
public class enigmaFinale : MonoBehaviour
{
    private List<GameObject> _cubes = new();

    //public Transform[] cubesPositions;
    public List<GameObject> soluzione;
    public List<GameObject> posizioni;
    public GameObject porta;
    public GameObject Player;
    public Camera cameraZoom;
    public GameObject maniglia;

    private int positionsIndex = 0;



    public void AddCube(GameObject cube)
    {        
        if(!cube.GetComponent<CubiInteracable>().touched){
            _cubes.Add(cube);
            GameObject posizione = posizioni[positionsIndex].gameObject;                        
            cube.transform.SetParent(posizione.transform);
            cube.transform.position = posizione.transform.position;
            //cube.transform.position = posizioni[positionsIndex].transform.position;
            positionsIndex++;
            cube.GetComponent<CubiInteracable>().touched = true;
        }
    }

    public void checkCombinazione(){
        for(int i = 0; i  < soluzione.Count; i++){
            if(!soluzione[i].name.Equals(posizioni[i].transform.GetChild(0).name)){
                Debug.Log(posizioni[i].transform.GetChild(0).name);
                return;
            }
        }
        for(int i = 0; i  < posizioni.Count; i++){
            posizioni[i].SetActive(false);
        }
        Player.GetComponent<AudioSource>().Play();
        maniglia.SetActive(false);
        transform.Rotate(0,90,0);
        gameObject.GetComponent<Collider>().gameObject.SetActive(false);
        porta.transform.Rotate(0,90,0);
        Player.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        cameraZoom.gameObject.SetActive(false);
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;        
        Debug.Log("Hai vinto");
    }
}
