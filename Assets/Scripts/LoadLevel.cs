using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour {

    public int minimumScoreNeeded = 0; //variabel för den minsta mängden score man behöver

    public string sceneToLoad = "SampleScene"; //Variablen sceneToLoad innebär att scenen SampleScene laddas.


    private void OnTriggerEnter2D(Collider2D collision) // När något nuddar en Is Trigger
    {
        if(collision.tag == "Player" && Coin.score >= minimumScoreNeeded) //om något med scriptet på sig nuddar något med taggen "Player", i detta fall våran player, OCH våran score är lika med eller mer än minimumScoreNeeded (hur mycket man behöver minst för att vinna)
        {
            
            Coin.score = 0; //sätter våran score tillbaka till 0
            SceneManager.LoadScene(sceneToLoad); //Laddar om scenen, i detta fall SampleScene.
            PlayerMovement.jumpSpeed = 12f; //när jag dog eller gick in i mål så startar banan om, men jag hade kvar min jumpspeed som jag fått från JumpSpeedPowerups, så därför sätts den om till dens ursprungliga värde.
        }
       
    }
}
