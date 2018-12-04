using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    


    // Update is called once per frame
    void Update()
    {
        if (Key.keyIsTaken == true) //om keyIsTaken (från Key scriptet) är true, alltså om man har tagit nyckeln
        { 
            Destroy(gameObject); //objectet försvinner
        }
    }
    
}
