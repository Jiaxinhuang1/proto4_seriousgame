using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBasket : MonoBehaviour
{
    public ForestUI uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "airAnim")
        {
            uiManager.airCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
