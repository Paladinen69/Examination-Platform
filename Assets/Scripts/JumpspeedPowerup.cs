using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpspeedPowerup : MonoBehaviour {

	

    private void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0); //diamanten roterar konstant
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") //om diamanten nuddar något med taggen Player
        {
            Destroy(gameObject); //spriten försvinner
            PlayerMovement.jumpSpeed = PlayerMovement.jumpSpeed + 1; //ändrar spelarens jumpspeed (hur högt den hoppar) med 1
        }
    }
}
