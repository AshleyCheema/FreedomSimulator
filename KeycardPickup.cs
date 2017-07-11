using UnityEngine;
using System.Collections;

public class KeycardPickup : MonoBehaviour
{
    PlayerMove playerMove;
    //When the player picks up the keycard it is stored
    //This allows for keycard to used again later in the game to get to the end
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Keycard")
        {
            playerMove.GetComponent<PlayerMove>().Inventory[0] = "Keycard";
            Debug.Log("Picked Up");
            Destroy(this.gameObject);
        }
    }

}
