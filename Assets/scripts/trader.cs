using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trader : MonoBehaviour
{
    public Pausemenu pausemenu;
    public Text buttonTraderText;
    public Text buttonTraderText1;
    public GameObject trader2;
    public GameObject buttonTrader;
    public bool buttonTrader2;
    public float traderDistance;
    public float money;
    public GameObject slotButton;
    public Inventory inventory;
    public int Lenght;
    public GameObject buttonTrader1;
    public GameObject slotButton2;
    public GameObject slotButton3;
    public GameObject slotButton4;
    public GameObject slotButton5;
    public GameObject slotButton6;
    public GameObject slotButton7;
    public GameObject slotButton8;
    public GameObject slotButton9;
    public GameObject slotButton10;
    public GameObject slotButton11;
    public GameObject slotButton12;
    public GameObject slotButton13;
    public GameObject slotButton14;
    public GameObject menuTrader1;
    public GameObject menuTrader2;
    public GameObject menuTrader3;
    public GameObject menuTrader4;
    public GameObject menuTrader5;
    public GameObject menuTrader6;
    public GameObject menuTrader7;
    public GameObject menuTrader8;
    public GameObject menuTrader9;
    public GameObject menuTrader10;
    public GameObject menuTrader11;
    public GameObject menuTrader12;
    public GameObject menuTrader13;
    public GameObject menuTrader14;
    public GameObject menuTrader1RU;
    public GameObject menuTrader2RU;
    public GameObject menuTrader3RU;
    public GameObject menuTrader4RU;
    public GameObject menuTrader5RU;
    public GameObject menuTrader6RU;
    public GameObject menuTrader7RU;
    public GameObject menuTrader8RU;
    public GameObject menuTrader9RU;
    public GameObject menuTrader10RU;
    public GameObject menuTrader11RU;
    public GameObject menuTrader12RU;
    public GameObject menuTrader13RU;
    public GameObject menuTrader14RU;
    public int menuTraderI;
    public PlayerController playerController;
    public GameObject Buybutton;
    public GameObject Buybutton2;
    public GameObject Buybutton3;
    public GameObject Buybutton4;
    public GameObject Buybutton5;
    public GameObject Buybutton6;
    public GameObject Buybutton7;
    public GameObject Buybutton8;
    public GameObject Buybutton9;
    public GameObject Buybutton10;
    public GameObject Buybutton11;
    public GameObject Buybutton12;
    public GameObject Buybutton13;
    public GameObject Buybutton14;
    public GameObject BuybuttonRU;
    public GameObject Buybutton2RU;
    public GameObject Buybutton3RU;
    public GameObject Buybutton4RU;
    public GameObject Buybutton5RU;
    public GameObject Buybutton6RU;
    public GameObject Buybutton7RU;
    public GameObject Buybutton8RU;
    public GameObject Buybutton9RU;
    public GameObject Buybutton10RU;
    public GameObject Buybutton11RU;
    public GameObject Buybutton12RU;
    public GameObject Buybutton13RU;
    public GameObject Buybutton14RU;
    public GameObject BuybuttonOFF;
    public GameObject Buybutton2OFF;
    public GameObject Buybutton3OFF;
    public GameObject Buybutton4OFF;
    public GameObject Buybutton5OFF;
    public GameObject Buybutton6OFF;
    public GameObject Buybutton7OFF;
    public GameObject Buybutton8OFF;
    public GameObject Buybutton9OFF;
    public GameObject Buybutton10OFF;
    public GameObject Buybutton11OFF;
    public GameObject Buybutton12OFF;
    public GameObject Buybutton13OFF;
    public GameObject Buybutton14OFF;
    public GameObject BuybuttonRUOFF;
    public GameObject Buybutton2RUOFF;
    public GameObject Buybutton3RUOFF;
    public GameObject Buybutton4RUOFF;
    public GameObject Buybutton5RUOFF;
    public GameObject Buybutton6RUOFF;
    public GameObject Buybutton7RUOFF;
    public GameObject Buybutton8RUOFF;
    public GameObject Buybutton9RUOFF;
    public GameObject Buybutton10RUOFF;
    public GameObject Buybutton11RUOFF;
    public GameObject Buybutton12RUOFF;
    public GameObject Buybutton13RUOFF;
    public GameObject Buybutton14RUOFF;
    public GameObject LBuybutton;
    public GameObject LBuybutton2;
    public GameObject LBuybutton3;
    public GameObject LBuybutton4;
    public GameObject LBuybutton5;
    public GameObject LBuybutton6;
    public GameObject LBuybutton7;
    public GameObject LBuybutton8;
    public GameObject LBuybutton9;
    public GameObject LBuybutton10;
    public GameObject LBuybutton11;
    public GameObject LBuybuttonRU;
    public GameObject LBuybutton2RU;
    public GameObject LBuybutton3RU;
    public GameObject LBuybutton4RU;
    public GameObject LBuybutton5RU;
    public GameObject LBuybutton6RU;
    public GameObject LBuybutton7RU;
    public GameObject LBuybutton8RU;
    public GameObject LBuybutton9RU;
    public GameObject LBuybutton10RU;
    public GameObject LBuybutton11RU;
    public Skills skills1;
    public float s1;
    public Level level1;
    public float moneyT1;
    public float moneyT2;
    public float moneyT3;
    public float moneyT4;
    public float moneyT5;
    public float moneyT6;
    public float moneyT7;
    public float moneyT8;
    public float moneyT9;
    public float moneyT10;
    public float moneyT11;
    public float moneyT12;
    public float moneyT13;
    public float moneyT14;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text1RU;
    public Text text2RU;
    public Text text3RU;
    public Text text4RU;
    public Text text5RU;
    public Text text6RU;
    public Text text7RU;
    public Text text8RU;
    public Text text9RU;
    public Text text10RU;
    public Text text11RU;
    public Text text12RU;
    public Text text13RU;
    public Text text14RU;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("m"))
        {
            money = PlayerPrefs.GetFloat("m");
        }
        inventory = gameObject.GetComponent<Inventory>();
        playerController = gameObject.GetComponent<PlayerController>();
        skills1 = gameObject.GetComponent<Skills>();
        level1 = gameObject.GetComponent<Level>();
        pausemenu = gameObject.GetComponent<Pausemenu>();
        training1 = gameObject.GetComponent<training>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("m", money);
        PlayerPrefs.Save();
        if (playerController.language == 0)
        {
            buttonTraderText.text = "Buy";
            buttonTraderText1.text = "Sell";
        }
        else
        {
            buttonTraderText.text = "Купить";
            buttonTraderText1.text = "Продать";
        }
        if(Vector2.Distance(transform.position, trader2.transform.position) < traderDistance && pausemenu.off == true)
        {
            buttonTrader2 = true;
            
        }
        else
        {
            buttonTrader2 = false;
        }
        buttonTrader.SetActive(buttonTrader2);
        buttonTrader1.SetActive(buttonTrader2);
        if(skills1.levelC3 == 1)
        {
            s1 = 0.9f;
        }
        else if(skills1.levelC3 == 2)
        {
            s1 = 0.8f;
        }
        else if (skills1.levelC3 == 3)
        {
            s1 = 0.7f;
        }
        else
        {
            s1 = 1f;
        }
        moneyT1 = 30 * s1;
        moneyT2 = 150 * s1;
        moneyT3 = 600 * s1;
        moneyT4 = 60 * s1;
        moneyT5 = 180 * s1;
        moneyT6 = 900 * s1;
        moneyT7 = 480 * s1;
        moneyT8 = 300 * s1;
        moneyT9 = 1500 * s1;
        moneyT10 = 2100 * s1;
        moneyT11 = 450 * s1;
        moneyT12 = 2700 * s1;
        moneyT13 = 3000 * s1;
        moneyT14 = 4050 * s1;
        text1.text = moneyT1.ToString() + " (" + money.ToString() + ")";
        text1RU.text = moneyT1.ToString() + " (" + money.ToString() + ")";
        text2.text = moneyT2.ToString() + " (" + money.ToString() + ")";
        text2RU.text = moneyT2.ToString() + " (" + money.ToString() + ")";
        text3.text = moneyT3.ToString() + " (" + money.ToString() + ")";
        text3RU.text = moneyT3.ToString() + " (" + money.ToString() + ")";
        text4.text = moneyT4.ToString() + " (" + money.ToString() + ")";
        text4RU.text = moneyT4.ToString() + " (" + money.ToString() + ")";
        text5.text = moneyT5.ToString() + " (" + money.ToString() + ")";
        text5RU.text = moneyT5.ToString() + " (" + money.ToString() + ")";
        text6.text = moneyT6.ToString() + " (" + money.ToString() + ")";
        text6RU.text = moneyT6.ToString() + " (" + money.ToString() + ")";
        text7.text = moneyT7.ToString() + " (" + money.ToString() + ")";
        text7RU.text = moneyT7.ToString() + " (" + money.ToString() + ")";
        text8.text = moneyT8.ToString() + " (" + money.ToString() + ")";
        text8RU.text = moneyT8.ToString() + " (" + money.ToString() + ")";
        text9.text = moneyT9.ToString() + " (" + money.ToString() + ")";
        text9RU.text = moneyT9.ToString() + " (" + money.ToString() + ")";
        text10.text = moneyT10.ToString() + " (" + money.ToString() + ")";
        text10RU.text = moneyT10.ToString() + " (" + money.ToString() + ")";
        text11.text = moneyT11.ToString() + " (" + money.ToString() + ")";
        text11RU.text = moneyT11.ToString() + " (" + money.ToString() + ")";
        text12.text = moneyT12.ToString() + " (" + money.ToString() + ")";
        text12RU.text = moneyT12.ToString() + " (" + money.ToString() + ")";
        text13.text = moneyT13.ToString() + " (" + money.ToString() + ")";
        text13RU.text = moneyT13.ToString() + " (" + money.ToString() + ")";
        text14.text = moneyT14.ToString() + " (" + money.ToString() + ")";
        text14RU.text = moneyT14.ToString() + " (" + money.ToString() + ")";
        if (money >= moneyT1)
        {
            text1.color = Color.green;
            text1RU.color = Color.green;
        }
        else
        {
            text1.color = Color.red;
            text1RU.color = Color.red;
        }
        if (money >= moneyT2)
        {
            text2.color = Color.green;
            text2RU.color = Color.green;
        }
        else
        {
            text2.color = Color.red;
            text2RU.color = Color.red;
        }
        if (money >= moneyT3)
        {
            text3.color = Color.green;
            text3RU.color = Color.green;
        }
        else
        {
            text3.color = Color.red;
            text3RU.color = Color.red;
        }
        if (money >= moneyT4)
        {
            text4.color = Color.green;
            text4RU.color = Color.green;
        }
        else
        {
            text4.color = Color.red;
            text4RU.color = Color.red;
        }
        if (money >= moneyT5)
        {
            text5.color = Color.green;
            text5RU.color = Color.green;
        }
        else
        {
            text5.color = Color.red;
            text5RU.color = Color.red;
        }
        if (money >= moneyT6)
        {
            text6.color = Color.green;
            text6RU.color = Color.green;
        }
        else
        {
            text6.color = Color.red;
            text6RU.color = Color.red;
        }
        if (money >= moneyT7)
        {
            text7.color = Color.green;
            text7RU.color = Color.green;
        }
        else
        {
            text7.color = Color.red;
            text7RU.color = Color.red;
        }
        if (money >= moneyT8)
        {
            text8.color = Color.green;
            text8RU.color = Color.green;
        }
        else
        {
            text8.color = Color.red;
            text8RU.color = Color.red;
        }
        if (money >= moneyT9)
        {
            text9.color = Color.green;
            text9RU.color = Color.green;
        }
        else
        {
            text9.color = Color.red;
            text9RU.color = Color.red;
        }
        if (money >= moneyT10)
        {
            text10.color = Color.green;
            text10RU.color = Color.green;
        }
        else
        {
            text10.color = Color.red;
            text10RU.color = Color.red;
        }
        if (money >= moneyT11)
        {
            text11.color = Color.green;
            text11RU.color = Color.green;
        }
        else
        {
            text11.color = Color.red;
            text11RU.color = Color.red;
        }
        if (money >= moneyT12)
        {
            text12.color = Color.green;
            text12RU.color = Color.green;
        }
        else
        {
            text12.color = Color.red;
            text12RU.color = Color.red;
        }
        if (money >= moneyT13)
        {
            text13.color = Color.green;
            text13RU.color = Color.green;
        }
        else
        {
            text13.color = Color.red;
            text13RU.color = Color.red;
        }
        if (money >= moneyT14)
        {
            text14.color = Color.green;
            text14RU.color = Color.green;
        }
        else
        {
            text14.color = Color.red;
            text14RU.color = Color.red;
        }
        if (money >= moneyT1)
        {
            Buybutton.SetActive(true);
            BuybuttonRU.SetActive(true);
            BuybuttonOFF.SetActive(false);
            BuybuttonRUOFF.SetActive(false);
        }
        else
        {
            Buybutton.SetActive(false);
            BuybuttonRU.SetActive(false);
            BuybuttonOFF.SetActive(true);
            BuybuttonRUOFF.SetActive(true);
        }
        if (money >= moneyT2)
        {
            Buybutton2.SetActive(true);
            Buybutton2RU.SetActive(true);
            Buybutton2OFF.SetActive(false);
            Buybutton2RUOFF.SetActive(false);
        }
        else
        {
            Buybutton2.SetActive(false);
            Buybutton2RU.SetActive(false);
            Buybutton2OFF.SetActive(true);
            Buybutton2RUOFF.SetActive(true);
        }
        if (money >= moneyT3)
        {
            Buybutton3.SetActive(true);
            Buybutton3RU.SetActive(true);
            Buybutton3OFF.SetActive(false);
            Buybutton3RUOFF.SetActive(false);
        }
        else
        {
            Buybutton3.SetActive(false);
            Buybutton3RU.SetActive(false);
            Buybutton3OFF.SetActive(true);
            Buybutton3RUOFF.SetActive(true);
        }
        if(level1.PlayerLevel >= 2)
        {
            LBuybutton.SetActive(false);
            LBuybuttonRU.SetActive(false);
            if (money >= moneyT4)
            {
                Buybutton4.SetActive(true);
                Buybutton4RU.SetActive(true);
                Buybutton4OFF.SetActive(false);
                Buybutton4RUOFF.SetActive(false);
            }
            else
            {
                Buybutton4.SetActive(false);
                Buybutton4RU.SetActive(false);
                Buybutton4OFF.SetActive(true);
                Buybutton4RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton4.SetActive(false);
            Buybutton4RU.SetActive(false);
            Buybutton4OFF.SetActive(false);
            Buybutton4RUOFF.SetActive(false);
            LBuybutton.SetActive(true);
            LBuybuttonRU.SetActive(true);
        }
        if (level1.PlayerLevel >= 4)
        {
            LBuybutton2.SetActive(false);
            LBuybutton2RU.SetActive(false);
            if (money >= moneyT5)
            {
                Buybutton5.SetActive(true);
                Buybutton5RU.SetActive(true);
                Buybutton5OFF.SetActive(false);
                Buybutton5RUOFF.SetActive(false);
            }
            else
            {
                Buybutton5.SetActive(false);
                Buybutton5RU.SetActive(false);
                Buybutton5OFF.SetActive(true);
                Buybutton5RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton5.SetActive(false);
            Buybutton5RU.SetActive(false);
            Buybutton5OFF.SetActive(false);
            Buybutton5RUOFF.SetActive(false);
            LBuybutton2.SetActive(true);
            LBuybutton2RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 5)
        {
            LBuybutton3.SetActive(false);
            LBuybutton3RU.SetActive(false);
            if (money >= moneyT6)
            {
                Buybutton6.SetActive(true);
                Buybutton6RU.SetActive(true);
                Buybutton6OFF.SetActive(false);
                Buybutton6RUOFF.SetActive(false);
            }
            else
            {
                Buybutton6.SetActive(false);
                Buybutton6RU.SetActive(false);
                Buybutton6OFF.SetActive(true);
                Buybutton6RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton6.SetActive(false);
            Buybutton6RU.SetActive(false);
            Buybutton6OFF.SetActive(false);
            Buybutton6RUOFF.SetActive(false);
            LBuybutton3.SetActive(true);
            LBuybutton3RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 8)
        {
            LBuybutton4.SetActive(false);
            LBuybutton4RU.SetActive(false);
            if (money >= moneyT7)
            {
                Buybutton7.SetActive(true);
                Buybutton7RU.SetActive(true);
                Buybutton7OFF.SetActive(false);
                Buybutton7RUOFF.SetActive(false);
            }
            else
            {
                Buybutton7.SetActive(false);
                Buybutton7RU.SetActive(false);
                Buybutton7OFF.SetActive(true);
                Buybutton7RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton7.SetActive(false);
            Buybutton7RU.SetActive(false);
            Buybutton7OFF.SetActive(false);
            Buybutton7RUOFF.SetActive(false);
            LBuybutton4.SetActive(true);
            LBuybutton4RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 10)
        {
            LBuybutton5.SetActive(false);
            LBuybutton5RU.SetActive(false);
            if (money >= moneyT8)
            {
                Buybutton8.SetActive(true);
                Buybutton8RU.SetActive(true);
                Buybutton8OFF.SetActive(false);
                Buybutton8RUOFF.SetActive(false);
            }
            else
            {
                Buybutton8.SetActive(false);
                Buybutton8RU.SetActive(false);
                Buybutton8OFF.SetActive(true);
                Buybutton8RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton8.SetActive(false);
            Buybutton8RU.SetActive(false);
            Buybutton8OFF.SetActive(false);
            Buybutton8RUOFF.SetActive(false);
            LBuybutton5.SetActive(true);
            LBuybutton5RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 10)
        {
            LBuybutton6.SetActive(false);
            LBuybutton6RU.SetActive(false);
            if (money >= moneyT9)
            {
                Buybutton9.SetActive(true);
                Buybutton9RU.SetActive(true);
                Buybutton9OFF.SetActive(false);
                Buybutton9RUOFF.SetActive(false);
            }
            else
            {
                Buybutton9.SetActive(false);
                Buybutton9RU.SetActive(false);
                Buybutton9OFF.SetActive(true);
                Buybutton9RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton9.SetActive(false);
            Buybutton9RU.SetActive(false);
            Buybutton9OFF.SetActive(false);
            Buybutton9RUOFF.SetActive(false);
            LBuybutton6.SetActive(true);
            LBuybutton6RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 15)
        {
            LBuybutton7.SetActive(false);
            LBuybutton7RU.SetActive(false);
            if (money >= moneyT10)
            {
                Buybutton10.SetActive(true);
                Buybutton10RU.SetActive(true);
                Buybutton10OFF.SetActive(false);
                Buybutton10RUOFF.SetActive(false);
            }
            else
            {
                Buybutton10.SetActive(false);
                Buybutton10RU.SetActive(false);
                Buybutton10OFF.SetActive(true);
                Buybutton10RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton10.SetActive(false);
            Buybutton10RU.SetActive(false);
            Buybutton10OFF.SetActive(false);
            Buybutton10RUOFF.SetActive(false);
            LBuybutton7.SetActive(true);
            LBuybutton7RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 15)
        {
            LBuybutton8.SetActive(false);
            LBuybutton8RU.SetActive(false);
            if (money >= moneyT11)
            {
                Buybutton11.SetActive(true);
                Buybutton11RU.SetActive(true);
                Buybutton11OFF.SetActive(false);
                Buybutton11RUOFF.SetActive(false);
            }
            else
            {
                Buybutton11.SetActive(false);
                Buybutton11RU.SetActive(false);
                Buybutton11OFF.SetActive(true);
                Buybutton11RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton11.SetActive(false);
            Buybutton11RU.SetActive(false);
            Buybutton11OFF.SetActive(false);
            Buybutton11RUOFF.SetActive(false);
            LBuybutton8.SetActive(true);
            LBuybutton8RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 15)
        {
            LBuybutton9.SetActive(false);
            LBuybutton9RU.SetActive(false);
            if (money >= moneyT12)
            {
                Buybutton12.SetActive(true);
                Buybutton12RU.SetActive(true);
                Buybutton12OFF.SetActive(false);
                Buybutton12RUOFF.SetActive(false);
            }
            else
            {
                Buybutton12.SetActive(false);
                Buybutton12RU.SetActive(false);
                Buybutton12OFF.SetActive(true);
                Buybutton12RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton12.SetActive(false);
            Buybutton12RU.SetActive(false);
            Buybutton12OFF.SetActive(false);
            Buybutton12RUOFF.SetActive(false);
            LBuybutton9.SetActive(true);
            LBuybutton9RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 20)
        {
            LBuybutton10.SetActive(false);
            LBuybutton10RU.SetActive(false);
            if (money >= moneyT13)
            {
                Buybutton13.SetActive(true);
                Buybutton13RU.SetActive(true);
                Buybutton13OFF.SetActive(false);
                Buybutton13RUOFF.SetActive(false);
            }
            else
            {
                Buybutton13.SetActive(false);
                Buybutton13RU.SetActive(false);
                Buybutton13OFF.SetActive(true);
                Buybutton13RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton13.SetActive(false);
            Buybutton13RU.SetActive(false);
            Buybutton13OFF.SetActive(false);
            Buybutton13RUOFF.SetActive(false);
            LBuybutton10.SetActive(true);
            LBuybutton10RU.SetActive(true);
        }
        if (level1.PlayerLevel >= 22)
        {
            LBuybutton11.SetActive(false);
            LBuybutton11RU.SetActive(false);
            if (money >= moneyT14)
            {
                Buybutton14.SetActive(true);
                Buybutton14RU.SetActive(true);
                Buybutton14OFF.SetActive(false);
                Buybutton14RUOFF.SetActive(false);
            }
            else
            {
                Buybutton14.SetActive(false);
                Buybutton14RU.SetActive(false);
                Buybutton14OFF.SetActive(true);
                Buybutton14RUOFF.SetActive(true);
            }
        }
        else
        {
            Buybutton14.SetActive(false);
            Buybutton14RU.SetActive(false);
            Buybutton14OFF.SetActive(false);
            Buybutton14RUOFF.SetActive(false);
            LBuybutton11.SetActive(true);
            LBuybutton11RU.SetActive(true);
        }
        if (playerController.language == 0)
        {
            menuTrader1RU.SetActive(false);
            menuTrader2RU.SetActive(false);
            menuTrader3RU.SetActive(false);
            menuTrader4RU.SetActive(false);
            menuTrader5RU.SetActive(false);
            menuTrader6RU.SetActive(false);
            menuTrader7RU.SetActive(false);
            menuTrader8RU.SetActive(false);
            menuTrader9RU.SetActive(false);
            menuTrader10RU.SetActive(false);
            menuTrader11RU.SetActive(false);
            menuTrader12RU.SetActive(false);
            menuTrader13RU.SetActive(false);
            menuTrader14RU.SetActive(false);
            if (menuTraderI == 0)
            {
                menuTrader1.SetActive(true);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 1)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(true);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 2)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(true);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 3)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(true);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 4)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(true);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 5)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(true);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 6)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(true);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 7)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(true);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 8)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(true);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 9)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(true);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 10)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(true);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 11)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(true);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(false);
            }
            else if (menuTraderI == 12)
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(true);
                menuTrader14.SetActive(false);
            }
            else
            {
                menuTrader1.SetActive(false);
                menuTrader2.SetActive(false);
                menuTrader3.SetActive(false);
                menuTrader4.SetActive(false);
                menuTrader5.SetActive(false);
                menuTrader6.SetActive(false);
                menuTrader7.SetActive(false);
                menuTrader8.SetActive(false);
                menuTrader9.SetActive(false);
                menuTrader10.SetActive(false);
                menuTrader11.SetActive(false);
                menuTrader12.SetActive(false);
                menuTrader13.SetActive(false);
                menuTrader14.SetActive(true);
            }
        }
        else
        {
            menuTrader1.SetActive(false);
            menuTrader2.SetActive(false);
            menuTrader3.SetActive(false);
            menuTrader4.SetActive(false);
            menuTrader5.SetActive(false);
            menuTrader6.SetActive(false);
            menuTrader7.SetActive(false);
            menuTrader8.SetActive(false);
            menuTrader9.SetActive(false);
            menuTrader10.SetActive(false);
            menuTrader11.SetActive(false);
            menuTrader12.SetActive(false);
            menuTrader13.SetActive(false);
            menuTrader14.SetActive(false);
            if (menuTraderI == 0)
            {
                menuTrader1RU.SetActive(true);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 1)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(true);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 2)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(true);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 3)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(true);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 4)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(true);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 5)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(true);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 6)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(true);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 7)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(true);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 8)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(true);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 9)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(true);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 10)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(true);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 11)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(true);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(false);
            }
            else if (menuTraderI == 12)
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(true);
                menuTrader14RU.SetActive(false);
            }
            else
            {
                menuTrader1RU.SetActive(false);
                menuTrader2RU.SetActive(false);
                menuTrader3RU.SetActive(false);
                menuTrader4RU.SetActive(false);
                menuTrader5RU.SetActive(false);
                menuTrader6RU.SetActive(false);
                menuTrader7RU.SetActive(false);
                menuTrader8RU.SetActive(false);
                menuTrader9RU.SetActive(false);
                menuTrader10RU.SetActive(false);
                menuTrader11RU.SetActive(false);
                menuTrader12RU.SetActive(false);
                menuTrader13RU.SetActive(false);
                menuTrader14RU.SetActive(true);
            }
        }
    }
    public void buy1()
    {
        if(money >= 600 * s1)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 4;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    money -= 600 * s1;
                    if (training1.training2i == 4)
                    {
                        training1.training3i4 += 1;
                    }
                    break;
                }
            }
        }
    }
    public void buy2()
    {
        if (money >= 30 * s1)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 5;
                    Instantiate(slotButton2, inventory.slots[i].transform);
                    money -= 30 * s1;
                    break;
                }
            }
        }
    }
    public void buy3()
    {
        if(level1.PlayerLevel >= 2)
        {
            if (money >= 60 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 8;
                        Instantiate(slotButton3, inventory.slots[i].transform);
                        money -= 60 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy4()
    {
        if(level1.PlayerLevel >= 4)
        {
            if (money >= 180 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 6;
                        Instantiate(slotButton4, inventory.slots[i].transform);
                        money -= 180 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy5()
    {
        if(level1.PlayerLevel >= 8)
        {
            if (money >= 480 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 7;
                        Instantiate(slotButton5, inventory.slots[i].transform);
                        money -= 480 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy6()
    {
        if (money >= 150 * s1)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 18;
                    Instantiate(slotButton6, inventory.slots[i].transform);
                    money -= 150 * s1;
                    break;
                }
            }
        }
    }
    public void buy7()
    {
        if(level1.PlayerLevel >= 10)
        {
            if (money >= 300 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 19;
                        Instantiate(slotButton7, inventory.slots[i].transform);
                        money -= 300 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy8()
    {
        if(level1.PlayerLevel >= 15)
        {
            if (money >= 450 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 20;
                        Instantiate(slotButton8, inventory.slots[i].transform);
                        money -= 450 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy9()
    {
        if(level1.PlayerLevel >= 5)
        {
            if (money >= 900 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 16;
                        Instantiate(slotButton9, inventory.slots[i].transform);
                        money -= 900 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy10()
    {
        if(level1.PlayerLevel >= 10)
        {
            if (money >= 1500 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 13;
                        Instantiate(slotButton10, inventory.slots[i].transform);
                        money -= 1500 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy11()
    {
        if(level1.PlayerLevel >= 15)
        {
            if (money >= 2100 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 14;
                        Instantiate(slotButton11, inventory.slots[i].transform);
                        money -= 2100 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy12()
    {
        if(level1.PlayerLevel >= 15)
        {
            if (money >= 2700 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 12;
                        Instantiate(slotButton13, inventory.slots[i].transform);
                        money -= 2700 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy13()
    {
        if(level1.PlayerLevel >= 22)
        {
            if (money >= 4050 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 11;
                        Instantiate(slotButton12, inventory.slots[i].transform);
                        money -= 4050 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void buy14()
    {
        if(level1.PlayerLevel >= 20)
        {
            if (money >= 3000 * s1)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (inventory.b[i] == 2)
                    {
                        inventory.b[i] = 15;
                        Instantiate(slotButton14, inventory.slots[i].transform);
                        money -= 3000 * s1;
                        break;
                    }
                }
            }
        }
    }
    public void menuON1()
    {
        menuTraderI = 0;
    }
    public void menuON2()
    {
        menuTraderI = 1;
    }
    public void menuON3()
    {
        menuTraderI = 2;
    }
    public void menuON4()
    {
        menuTraderI = 3;
    }
    public void menuON5()
    {
        menuTraderI = 4;
    }
    public void menuON6()
    {
        menuTraderI = 5;
    }
    public void menuON7()
    {
        menuTraderI = 6;
    }
    public void menuON8()
    {
        menuTraderI = 7;
    }
    public void menuON9()
    {
        menuTraderI = 8;
    }
    public void menuON10()
    {
        menuTraderI = 9;
    }
    public void menuON11()
    {
        menuTraderI = 10;
    }
    public void menuON12()
    {
        menuTraderI = 11;
    }
    public void menuON13()
    {
        menuTraderI = 12;
    }
    public void menuON14()
    {
        menuTraderI = 13;
    }
}
