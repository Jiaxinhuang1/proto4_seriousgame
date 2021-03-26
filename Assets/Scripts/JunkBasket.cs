using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkBasket : MonoBehaviour
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
        if (collision.tag == "JunkFood")
        {
            uiManager.junkCount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Veggies" || collision.tag == "Fruits")
        {
            errorText.SetActive(true);
            Invoke(nameof(ResetPopup), timeBetweenPopup);

        }
    }
}
