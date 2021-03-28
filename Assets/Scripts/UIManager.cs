using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text junkText;
    public Text veggiesText;
    public Text fruitsText;

    public int junkCount;
    public int veggiesCount;
    public int fruitsCount;

    public GameObject nextPanel;

    // Start is called before the first frame update
    void Start()
    {
        junkCount = 0;
        veggiesCount = 0;
        fruitsCount = 0;

        nextPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        junkText.text = "Junk Food: " + junkCount;
        veggiesText.text = "Veggies: " + veggiesCount;
        fruitsText.text = "Fruits: " + fruitsCount;

        if (junkCount >= 3 && veggiesCount >= 3 && fruitsCount >= 3)
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
