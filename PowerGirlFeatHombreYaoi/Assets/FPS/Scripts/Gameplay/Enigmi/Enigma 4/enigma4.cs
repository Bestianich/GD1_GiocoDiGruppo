using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigma4 : MonoBehaviour
{       
    public GameObject tv;
    public AudioSource audioSOurce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiaCanale(GameObject canale){
        tv.GetComponent<MeshRenderer>().material = canale.GetComponent<MeshRenderer>().material;
        audioSOurce.Play();
        tv.gameObject.SetActive(true);
    }
}
