using UnityEngine;
using System.Collections;



public class WallTest : MonoBehaviour
{

    public float speed = 20;

    public GameObject Player;
    public Rigidbody PlayerRB;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("trump");
            PlayerRB.AddForce(Vector3.right * speed);
         
        }





    }

}
