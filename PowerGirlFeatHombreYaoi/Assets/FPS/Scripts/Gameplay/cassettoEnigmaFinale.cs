using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cassettoEnigmaFinale : MonoBehaviour , IPointerClickHandler
{
    // Start is called before the first frame update
        public enigmaFinale controller;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("non mi fa bestemmia'");
        controller.checkCombinazione();
    }
}
