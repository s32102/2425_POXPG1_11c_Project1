using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameController : MonoBehaviour
{
    public string WORD = "after";
    public TextMeshProUGUI wordtxt;
    public TextMeshProUGUI OurInput
    public InputField InputField

    // Start is called before the first frame update
    void Start()
    {
        wordtxt.text = WORD;  
    }

    public void OnInputChanged(string input)
    {
        OurInputChanged.text = InputField;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
