using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JunkyardUI : MonoBehaviour
{
    public Text metalText;
    public Text plasticText;
    public Text glassText;

    public int metalCount;
    public int plasticCount;
    public int glassCount;

    public GameObject nextPanel;

    // Start is called before the first frame update
    void Start()
    {
        metalCount = 0;
        plasticCount = 0;
        glassCount = 0;

        nextPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        metalText.text = "Metal: " + metalCount;
        plasticText.text = "Plastic: " + plasticCount;
        glassText.text = "Glass: " + glassCount;

        if (metalCount == 1 && plasticCount == 1 && glassCount == 1)
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
