using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public InputField Searchext;
    public GameObject TextWord;

    string Lay;
    string Taro;
    string Bento;
    string Cornae;
    string Lotus;

    // Start is called before the first frame update
    void Start()
    {
        Lay = "Lay";
        Taro = "Taro";
        Bento = "Bento";
        Cornae = "Cornae";
        Lotus = "Lotus";
    }

    // Update is called once per frame
    public void SearchingWord()
    {
        if (Searchext.text == "Lay")
        {
            TextWord.GetComponent<Text>().text = "[ " + Lay + " ] is found.";
        }
        else if (Searchext.text == "Taro")
        {
            TextWord.GetComponent<Text>().text = "[ " + Taro + " ] is found.";
        }
        else if (Searchext.text == "Bento")
        {
            TextWord.GetComponent<Text>().text = "[ " + Bento + " ] is found.";
        }
        else if (Searchext.text == "Cornae")
        {
            TextWord.GetComponent<Text>().text = "[ " + Cornae + " ] is found.";
        }
        else if (Searchext.text == "Lotus")
        {
            TextWord.GetComponent<Text>().text = "[ " + Lotus + " ] is found.";
        }
        else
        {
            TextWord.GetComponent<Text>().text = "Not found.";
        }
    }
}
