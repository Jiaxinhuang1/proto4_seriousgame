using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieBasket : MonoBehaviour
{
    public UIManager uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Veggies")
        {
            uiManager.veggiesCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
