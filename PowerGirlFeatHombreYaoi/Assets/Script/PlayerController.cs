using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] [Header("Player Speed")]
    public float speed;    
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {             
        movimento();
    }

    void movimento(){
        Vector3 playerPos = new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical"));
        transform.Translate(playerPos*(speed*Time.deltaTime) , Space.World );
    }
     
}
