using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBasket : MonoBehaviour
{
    public JunkyardUI uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "glass")
        {
            uiManager.glassCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
