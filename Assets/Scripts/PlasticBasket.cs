using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticBasket : MonoBehaviour
{
    public JunkyardUI uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "plastic")
        {
            uiManager.plasticCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
