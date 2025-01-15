/*
 Componente da dare al player per rendere possibile l'interazione con i cubi
*/

using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Camera _camera;

    public LayerMask cubeLayer;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("Interacting");
            Ray ray = new Ray(_camera.transform.position, _camera.transform.forward);
            if (Physics.Raycast(ray, out var hit ,Mathf.Infinity, cubeLayer)) {
                var cube = hit.transform.gameObject.GetComponent<CubiInteracable>();
                if (cube != null){
                    cube.Interact();
                } else {
                    var lastra = hit.transform.gameObject.GetComponent<lastreInteractable>();
                    if(!lastra.IsUnityNull()){
                        lastra.Interact();
                    }
                }
            }

        }
    }
}