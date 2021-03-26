using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBasket : MonoBehaviour
{
    public JunkyardUI uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "metal")
        {
            uiManager.metalCount += 1;
            Destroy(collision.gameObject);
        }

    }
}
