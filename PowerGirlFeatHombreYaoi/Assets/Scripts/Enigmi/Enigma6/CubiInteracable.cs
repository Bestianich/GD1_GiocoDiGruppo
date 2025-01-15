using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubiInteracable : MonoBehaviour
/*
 Componente da dare ai cubi per farli aggiungere all'enigma
 */
{
    [SerializeField] private Enigma6Controller _manager;
    public bool touched = false;
    public GameObject Player;

    public void Interact()
    {        
        Player.GetComponents<AudioSource>()[1].Play();
        _manager.AddCube(this.gameObject);
    }
}