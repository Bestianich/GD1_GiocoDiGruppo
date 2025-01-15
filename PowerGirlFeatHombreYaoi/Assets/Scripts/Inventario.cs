using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<GameObject> cubi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void InsertCubo(GameObject cubo){
        cubi.Add(cubo);
        cubo.GetComponent<MeshRenderer>().gameObject.SetActive(false);
        cubo.GetComponent<BoxCollider>().gameObject.SetActive(false);
    }
}
