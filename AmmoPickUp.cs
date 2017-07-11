using UnityEngine;
using System.Collections;

public class AmmoPickUp : MonoBehaviour
{
    AimShootRight playerAmmo;

    // Use this for initialization
    void Start()
    {
        playerAmmo = GameObject.FindGameObjectWithTag("Gun").GetComponent<AimShootRight>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ammo")
        {
            playerAmmo.GetComponent<AimShootRight>().ammo += 5;
            Destroy(this.gameObject);
        }
    }
}
