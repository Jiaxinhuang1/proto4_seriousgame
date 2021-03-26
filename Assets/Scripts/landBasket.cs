﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landBasket : MonoBehaviour
{
    public ForestUI uiManager;

    public GameObject errorText;
    private float timeBetweenPopup = 2f;

    private void ResetPopup()
    {
        errorText.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "landAnim")
        {
            uiManager.landCount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "waterAnim" || collision.tag == "airAnim")
        {
            errorText.SetActive(true);
            Invoke(nameof(ResetPopup), timeBetweenPopup);
            
        }
    }
}