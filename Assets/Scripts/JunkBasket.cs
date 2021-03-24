using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkBasket : MonoBehaviour
{
    public UIManager uiManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "JunkFood")
        {
            uiManager.junkCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
