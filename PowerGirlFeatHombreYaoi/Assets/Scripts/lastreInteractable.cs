using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastreInteractable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private enigmaFinale _manager;
    public bool touched = false;
    public GameObject Player;

    public void Interact()
    {                
        Player.GetComponents<AudioSource>()[1].Play();
        _manager.AddCube(this.gameObject);
    }
}
