using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBasket : MonoBehaviour
{
    public JunkyardUI uiManager;
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
        if (collision.tag == "metal")
        {
            uiManager.metalCount += 1;
            collectSound.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "plastic" || collision.tag == "glass")
        {
            errorText.SetActive(true);
            errorSound.Play();
            Invoke(nameof(ResetPopup), timeBetweenPopup);

        }

    }
}
