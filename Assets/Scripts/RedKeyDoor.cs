using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKeyDoor : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (RedKey.redKeyIsTaken == true) //om keyIsTaken (från Key scriptet) är true, alltså om man har tagit nyckeln
        {
            Destroy(gameObject); //objectet försvinner
        }
    }
}
