using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landBasket : MonoBehaviour
{
    public ForestUI uiManager;
    public GameObject errorText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "landAnim")
        {
            uiManager.landCount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "waterAnim" || collision.tag == "airAnim")
        {
            Debug.Log("eror");
            Instantiate(errorText, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
