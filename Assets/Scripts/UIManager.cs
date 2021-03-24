using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text junkText;
    public Text veggiesText;
    public Text fruitsText;

    public int junkCount;
    public int veggiesCount;
    public int fruitsCount;

    // Start is called before the first frame update
    void Start()
    {
        junkCount = 0;
        veggiesCount = 0;
        fruitsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        junkText.text = "Junk Food: " + junkCount;
        veggiesText.text = "Veggies: " + veggiesCount;
        fruitsText.text = "Fruits: " + fruitsCount;
    }
}
