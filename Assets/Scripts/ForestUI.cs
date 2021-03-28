using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ForestUI : MonoBehaviour
{
    public Text landText;
    public Text airText;
    public Text waterText;

    public int landCount;
    public int airCount;
    public int waterCount;

    public GameObject nextPanel;

    // Start is called before the first frame update
    void Start()
    {
        landCount = 0;
        airCount = 0;
        waterCount = 0;

        nextPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        landText.text = "Land Animal: " + landCount;
        airText.text = "Air Animal: " + airCount;
        waterText.text = "Water Animal: " + waterCount;

        if (landCount >= 2 && airCount >= 2 && waterCount >= 2)
        {
            nextPanel.SetActive(true);
        }
        else
        {
            nextPanel.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
