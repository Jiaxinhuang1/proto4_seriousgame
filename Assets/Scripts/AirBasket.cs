using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBasket : MonoBehaviour
{
    public ForestUI uiManager;

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
        if (collision.tag == "airAnim")
        {
            uiManager.airCount += 1;
            collectSound.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "waterAnim" || collision.tag == "landAnim")
        {
            errorText.SetActive(true);
            errorSound.Play();
            Invoke(nameof(ResetPopup), timeBetweenPopup);
        }
    }
}
