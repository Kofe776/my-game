using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class training : MonoBehaviour
{
    public int training2i;
    public GameObject trainingBackground1i;
    public Text trainingBackground1iText;
    public Text trainingBackground1iText2;
    public GameObject trainingBackground1i2;
    public GameObject trainingBackground1i3;
    public GameObject trainingBackground2i;
    public Text trainingBackground2iText;
    public PlayerController playerController;
    public Pausemenu pausemenu1;
    public int training3i;
    public int training3i2;
    public int training3i3;
    public GameObject training3iBackground1;
    public bool training3iBackground2;
    public trader trader1;
    public bool a1;
    public GameObject training3i2Background1;
    public bool training3i2Background2;
    public GameObject training3i3Background1;
    public bool training3i3Background2;
    public int training3i4;
    public GameObject training3i4Background1;
    public bool training3i4Background2;
    public int training3i5;
    public GameObject training3i5Background1;
    public bool training3i5Background2;
    public GameObject training3i6Background1;
    public bool training3i6Background2;
    public Level level1;
    // Start is called before the first frame update
    void Start()
    {
        playerController = gameObject.GetComponent<PlayerController>();
        level1 = gameObject.GetComponent<Level>();
        if (PlayerPrefs.HasKey("Training3"))
        {
            training2i = PlayerPrefs.GetInt("Training3");
        }
        else
        {

        }
        if (PlayerPrefs.HasKey("Training4"))
        {
            training3i = PlayerPrefs.GetInt("Training4");
        }
        else
        {

        }
        if (PlayerPrefs.HasKey("Training5"))
        {
            training3i2 = PlayerPrefs.GetInt("Training5");
        }
        else
        {

        }
        if (PlayerPrefs.HasKey("Training6"))
        {
            training3i3 = PlayerPrefs.GetInt("Training6");
        }
        else
        {

        }
        pausemenu1 = gameObject.GetComponent<Pausemenu>();
        trader1 = gameObject.GetComponent<trader>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Training3", training2i);
        PlayerPrefs.SetInt("Training4", training3i);
        PlayerPrefs.SetInt("Training5", training3i2);
        PlayerPrefs.SetInt("Training6", training3i3);
        PlayerPrefs.Save();
        if(training2i == 0)
        {
            trainingBackground1i.SetActive(true);
            trainingBackground1i2.SetActive(true);
            trainingBackground1i3.SetActive(true);
            trainingBackground2i.SetActive(false);
        }
        else if(training2i > 0 && training2i < 7)
        {
            trainingBackground1i.SetActive(false);
            trainingBackground1i2.SetActive(false);
            trainingBackground1i3.SetActive(false);
            
            if (pausemenu1.off == true)
            {
                trainingBackground2i.SetActive(true);
            }
            else
            {
                trainingBackground2i.SetActive(false);
            }
        }
        else
        {
            trainingBackground1i.SetActive(false);
            trainingBackground1i2.SetActive(false);
            trainingBackground1i3.SetActive(false);
            trainingBackground2i.SetActive(false);
        }
        training3iBackground1.SetActive(training3iBackground2);
        if(training3i >= 2 && training2i == 1)
        {
            training3i = 0;
            training3iBackground2 = true;
            training2i = 2;
            trader1.money += 200;
            
        }
        training3i2Background1.SetActive(training3i2Background2);
        if(training3i2 >= 3 && training2i == 2)
        {
            training3i2 = 0;
            training3i2Background2 = true;
            training2i = 3;
            trader1.money += 200;
        }
        training3i3Background1.SetActive(training3i3Background2);
        if(training3i3 >= 2 && training2i == 3)
        {
            training3i3 = 0;
            training3i3Background2 = true;
            training2i = 4;
            trader1.money += 200;
        }
        training3i4Background1.SetActive(training3i4Background2);
        if (training3i4 >= 1 && training2i == 4)
        {
            training3i4 = 0;
            training3i4Background2 = true;
            training2i = 5;
            trader1.money += 200;
        }
        training3i5Background1.SetActive(training3i5Background2);
        if (training3i5 >= 1 && training2i == 5)
        {
            training3i5 = 0;
            training3i5Background2 = true;
            training2i = 6;
            trader1.money += 200;
        }
        training3i6Background1.SetActive(training3i6Background2);
        if (level1.PlayerLevel >= 5 && training2i == 6)
        {
            
            training3i6Background2 = true;
            training2i = 7;
            trader1.money += 200;
        }
        if (playerController.language == 0)
        {
            trainingBackground1iText.text = "Use the left joystick to move around";
            trainingBackground1iText2.text = "Use the right joystick to attack";
            if (training2i == 1)
            {
                trainingBackground2iText.text = "Defeat 2 enemies (" + training3i.ToString() + " / 2)";
            }
            else if (training2i == 2)
            {
                trainingBackground2iText.text = "Collect the berries (" + training3i2.ToString() + " / 3)";
            }
            else if (training2i == 3)
            {
                trainingBackground2iText.text = "Sell 2 items to a trader (" + training3i3.ToString() + " / 2)";
            }
            else if (training2i == 4)
            {
                trainingBackground2iText.text = "Create a pistol or buy it from a trader";
            }
            else if (training2i == 5)
            {
                trainingBackground2iText.text = "Learn the skill";
            }
            else if (training2i == 6)
            {
                trainingBackground2iText.text = "Reach level 5";
            }
            else
            {
                trainingBackground2iText.text = "";
            }
        }
        else
        {
            trainingBackground1iText.text = "Используйте левый джойстик для передвижения";
            trainingBackground1iText2.text = "Используйте правый джойстик для атаки";
            if(training2i == 1)
            {
                trainingBackground2iText.text = "Победите 2 врагов (" + training3i.ToString() + " / 2)";
            }
            else if(training2i == 2)
            {
                trainingBackground2iText.text = "Соберите ягоды (" + training3i2.ToString() + " / 3)";
            }
            else if (training2i == 3)
            {
                trainingBackground2iText.text = "Продайте 2 предмета торговцу (" + training3i3.ToString() + " / 2)";
            }
            else if (training2i == 4)
            {
                trainingBackground2iText.text = "Создайте пистолет или купите его у торговца";
            }
            else if (training2i == 5)
            {
                trainingBackground2iText.text = "Изучите навык";
            }
            else if (training2i == 6)
            {
                trainingBackground2iText.text = "Достигните 5 уровня";
            }
            else
            {
                trainingBackground2iText.text = "";
            }
        }
        if(training3iBackground2 == true)
        {
            a1 = true;
        }
        else if(training3i2Background2 == true)
        {
            a1 = true;
        }
        else if (training3i3Background2 == true)
        {
            a1 = true;
        }
        else if (training3i4Background2 == true)
        {
            a1 = true;
        }
        else if (training3i5Background2 == true)
        {
            a1 = true;
        }
        else if (training3i6Background2 == true)
        {
            a1 = true;
        }
        else
        {
            a1 = false;
        }
    }
    public void trainingUp1()
    {
        training2i = 1;
    }
    public void trainingBackgroundOff1()
    {
        training3iBackground2 = false;
        
    }
    public void trainingBackgroundOff2()
    {
        training3i2Background2 = false;
    }
    public void trainingBackgroundOff3()
    {
        training3i3Background2 = false;
    }
    public void trainingBackgroundOff4()
    {
        training3i4Background2 = false;
    }
    public void trainingBackgroundOff5()
    {
        training3i5Background2 = false;
    }
    public void trainingBackgroundOff6()
    {
        training3i6Background2 = false;
    }
}
