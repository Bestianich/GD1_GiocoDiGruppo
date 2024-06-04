using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class maniglia6 : MonoBehaviour, IPointerClickHandler
{
    public Enigma6Controller controller;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("non mi fa bestemmia'");
        controller.checkCombinazione();
    }
}
