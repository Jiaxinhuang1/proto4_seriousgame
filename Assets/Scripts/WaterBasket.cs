using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBasket : MonoBehaviour
{
    public ForestUI uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "waterAnim")
        {
            uiManager.waterCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
