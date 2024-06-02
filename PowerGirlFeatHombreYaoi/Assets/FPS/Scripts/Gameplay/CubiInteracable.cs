using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubiInteracable : MonoBehaviour
{
    public Camera cameraEn6;
    public GameObject Position; 
    public GameObject Player;
    private GameObject selectedObject;
    
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(selectedObject == null)
            {
                Debug.Log("Selected obj = null");
                RaycastHit hit = CastRay();

                if(hit.collider != null)
                {
                    if(!hit.collider.CompareTag("Drag"))
                    {
                        return;
                    }

                    selectedObject = hit.collider.gameObject;
                    Cursor.visible = false;
                }
            } 
            else 
            {
                Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, cameraEn6.WorldToScreenPoint(selectedObject.transform.position).z);
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
                selectedObject.transform.position = new Vector3 (worldPosition.x, 0f, worldPosition.z);

                selectedObject = null; 
                Cursor.visible = true;
            }
        }

        if(selectedObject != null)
        {
            Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, cameraEn6.WorldToScreenPoint(selectedObject.transform.position).z);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
            selectedObject.transform.position = new Vector3 (worldPosition.x, 0.25f, worldPosition.z);
        }

    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 screenMousePosNear = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        Debug.Log("Aiutami Per Favore");

        Vector3 worldPositionFar = Camera.main.ScreenToWorldPoint (screenMousePosFar);
        Vector3 worldPositionNear = Camera.main.ScreenToWorldPoint (screenMousePosNear);

        RaycastHit hit;
        Physics.Raycast(worldPositionNear, worldPositionFar - worldPositionNear, out hit);

        return hit;
    }
}