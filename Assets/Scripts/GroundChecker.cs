using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

    public int isGrounded; //en bool för om det är sant eller falsk om något nuddar marken



    private void OnTriggerEnter2D(Collider2D collision) //någon Is Trigger nuddar något
    {
            isGrounded++; //det är sant, isGrounded är då true när collidern nuddar något   
    }
    private void OnTriggerExit2D(Collider2D collision) // någon Is Trigger nuddar inte något
    {
        isGrounded--; //det är falskt, isGrounded är då falskt.
    }
}
