using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKeyDoor : MonoBehaviour
{
    


    // Update is called once per frame
    void Update()
    {
        if (YellowKey.yellowKeyIsTaken == true) //om keyIsTaken (från Key scriptet) är true, alltså om man har tagit nyckeln
        { 
            Destroy(gameObject); //objectet försvinner
        }
    }
    
}
