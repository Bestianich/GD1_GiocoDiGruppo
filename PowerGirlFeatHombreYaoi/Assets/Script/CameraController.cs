using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    private float rotationX = 0f;
    private float rotationY = 0f;
    [Header("Sensibilità Mouse")]
    public float sensitivity = 15f;
    private Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        rotate = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")*sensitivity , 0);        
        transform.eulerAngles = transform.eulerAngles - rotate;

    }
}
