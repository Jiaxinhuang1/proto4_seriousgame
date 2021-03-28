using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsBasket : MonoBehaviour
{
    public UIManager uiManager;
    public GameObject errorText;
    private float timeBetweenPopup = 2f;
    public AudioSource collectSound;
    public AudioSource errorSound;
    private void ResetPopup()
    {
        errorText.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fruits")
        {
            uiManager.fruitsCount += 1;
            collectSound.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Veggies" || collision.tag == "JunkFood")
        {
            errorText.SetActive(true);
            errorSound.Play();
            Invoke(nameof(ResetPopup), timeBetweenPopup);

        }
    }
}
