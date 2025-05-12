using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameController : MonoBehaviour
{
    public string WORD = "after";
    public int livesCount = 10;
    public TextMeshProUGUI wordtxt;
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI livesCountText;
    public TMP_InputField InputField;

    // Start is called before the first frame update
    void Start()
    {
        wordtxt.text = WORD;  
        livesCountText.text =$"Zsotało {livesCount} prób";
    }
    
    public void OnClick()
    {
        Debug.Log($"Guzik został kliknięty");
        livesCount -= 1;
        livesCountText.text =$"Zsotało {livesCount} prób";

        if(WORD == InputField.text)
        {
            messageText.text = $"Wpisano poprawne słowo";
            return; //Koniec metody
        }
        if(WORD.Length != InputField.text.Length)
        {
            messageText.text = $"Liczba liter się nie zgadza";
            return; //Koniec metody
        }
        int bullsCount = CountBulls();
        int cowsCount = CountCows();
        messageText.text = $"Bulls: {bullsCount} and Cows: {cowsCount}";

    }

    public int CountBulls()
    {
        int result = 0;

        for (int i = 0; i < WORD.Length; i++)
        {
            if (WORD[i] == InputField.text[i])
            {
                result++;
            }
        }
        return result;
     
    }
     public int CountCows()
    {
       
       int result = 0;

        for (int i = 0; i < WORD.Length; i++)
        {
            if (WORD[i] != InputField.text[i] && WORD.Contains(InputField.text[i]))
            {
                result++;
            }
        }
        return result;
     
    }


    public void OnInputChanged(string input)
    {
        //OurInput.text = InputField.text;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
