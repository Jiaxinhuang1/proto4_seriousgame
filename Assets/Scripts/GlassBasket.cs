using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBasket : MonoBehaviour
{
    public JunkyardUI uiManager;
    public GameObject errorText;
    private float timeBetweenPopup = 2f;

    private void ResetPopup()
    {
        errorText.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "glass")
        {
            uiManager.glassCount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "plastic" || collision.tag == "metal")
        {
            errorText.SetActive(true);
            Invoke(nameof(ResetPopup), timeBetweenPopup);

        }
    }
}
