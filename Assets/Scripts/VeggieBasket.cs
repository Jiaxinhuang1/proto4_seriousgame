using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieBasket : MonoBehaviour
{
    public UIManager uiManager;
    public GameObject errorText;
    private float timeBetweenPopup = 2f;

    private void ResetPopup()
    {
        errorText.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Veggies")
        {
            uiManager.veggiesCount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "JunkFood" || collision.tag == "Fruits")
        {
            errorText.SetActive(true);
            Invoke(nameof(ResetPopup), timeBetweenPopup);

        }
    }
}
