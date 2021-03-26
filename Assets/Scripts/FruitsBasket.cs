using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsBasket : MonoBehaviour
{
    public UIManager uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fruits")
        {
            uiManager.fruitsCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
