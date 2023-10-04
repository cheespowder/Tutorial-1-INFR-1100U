using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            if (gameObject)
                Debug.Log("Coin collected");
        }

        Destroy(gameObject);
    }

    
}
