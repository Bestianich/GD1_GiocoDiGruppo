using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class LasteManager : MonoBehaviour
{
    public static int counter = 0;
    public TextMeshProUGUI counterText;

    void Start()
    {
        counterText = GameObject.Find("CounterText").GetComponent<TextMeshProUGUI>();

        UpdateCounterText();
    }
    // Start is called before the first frame update
  void OnMouseDown()
  {
    if(Input.GetMouseButtonDown(0))
    {
        counter++;
        UpdateCounterText();
        Destroy(gameObject);
    }
  }
    void UpdateCounterText()
    {
        counterText.text = counter + "/4"; 
    }
}

