using UnityEngine;
using System.Collections;

public class InventoryCheck : MonoBehaviour
{
    public string user;
    public string correctKey;
    PlayerMove playerMove;
    public Animator Elevator;
    public float Timer;
    public AudioVolume audioVolume;


    public bool key = false;

    void Start()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        Elevator.enabled = false;
    }

    //This checks to see if the user has the collected the key for the elevator
    void Update()

    {


        correctKey = "Keycard";
    
        user = playerMove.Inventory[0];

        foreach(string x in playerMove.Inventory)
        {
            if(x.Contains(correctKey))
            {
                //Debug.Log("Key");
                key = true;
            }
        }
        
   }
    //This trigger opens the elevator when the player has returned with the keycard
    //There is a small delay between playing the animation and when the player is moved down
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(key == true)
            {
                Elevator.enabled = true;


                    Timer = Timer - Time.deltaTime;

                    if(Timer <= 0)
                    {    
                      other.transform.position = new Vector2(84.50f, -40f);
                      audioVolume.PlayMusic();  
                }

                Debug.Log("Move");
            }
            else
            {
                Debug.Log("No Key");
            }
        }
    }
}
