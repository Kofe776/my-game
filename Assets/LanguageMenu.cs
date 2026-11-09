using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageMenu : MonoBehaviour
{
    public GameObject languagemenu2;
    public int language;
    public Image image1;
    public Sprite image2;
    public Sprite image3;
    public bool languagemenuON;
    public Text text1;
    public Text text2;
    public Text text3;
    // Start is called before the first frame update
    void Start()
    {
        image1 = gameObject.GetComponent<Image>();
        languagemenuON = false;
        if (PlayerPrefs.HasKey("language"))
        {
            language = PlayerPrefs.GetInt("language");
        }
        else
        {
            language = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("language", language);
        if (language == 0)
        {
            image1.sprite = image3;
            text1.text = "Resume";
            text2.text = "New game";
            text3.text = "Exit";
        }
        else
        {
            image1.sprite = image2;
            text1.text = "Продолжить";
            text2.text = "Новая игра";
            text3.text = "Выход";
        }
        languagemenu2.SetActive(languagemenuON);
    }
    public void menuOn1()
    {
        if(languagemenuON == false)
        {
            languagemenuON = true;
        }
        else
        {
            languagemenuON = false;
        }
    }
    public void language2()
    {
        language = 0;
    }
    public void language3()
    {
        language = 1;
    }
}
