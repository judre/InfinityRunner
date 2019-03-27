using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    HUDscript hudd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            hudd = GameObject.Find("Main Camera").GetComponent<HUDscript>();
            hudd.increaseScore(10);
            Destroy(this.gameObject);
        }
    }
}
