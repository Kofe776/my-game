using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public Image helthbar;
    public Image helthbarEffect;
    public Image helthbar2;
    public Image helthbarEffect2;
    public float maxhealt;
    public static float healt;
    public float healtspeed;
    public float h;
    public InventoryOpen inventoryOpen;
    public float s;
    public Skills skills;
    public Text text1;
    public bool a1;
    public trader trader1;
    public float a2;
    public float a3;
    public GameObject a4;
    public Text text2;
    public Text text3;
    public Text text4;
    public PlayerController playerController;
    public float map1;
    public float mapTime;
    public float mapTimeStart;
    // Start is called before the first frame update
    void Start()
    {
        
        if(PlayerPrefs.HasKey("HP"))
        {
            healt = PlayerPrefs.GetFloat("HP");
        }
        else
        {
            healt = maxhealt;
        }
        skills = gameObject.GetComponent<Skills>();
        a1 = false;
        trader1 = gameObject.GetComponent<trader>();
        playerController = gameObject.GetComponent<PlayerController>();
        mapTime = mapTimeStart;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -70)
        {
            mapTime -= Time.deltaTime;
        }
        else
        {
            mapTime = mapTimeStart;
        }
        if(mapTime <= 0)
        {
            healt -= map1;
            mapTime = mapTimeStart;
        }
        a2 = trader1.money * 0.05f;
        a3 = (int)a2;
        if(skills.levelB6 == 1)
        {
            maxhealt = 125;
        }
        else if(skills.levelB6 == 2)
        {
            maxhealt = 150;
        }
        else if (skills.levelB6 == 3)
        {
            maxhealt = 175;
        }
        else
        {
            maxhealt = 100;
        }
        if (healt > maxhealt)
        {
            healt = maxhealt;
        }
        helthbar.fillAmount = healt / maxhealt;
        if(helthbarEffect.fillAmount > helthbar.fillAmount)
        {
            helthbar.fillAmount -= healtspeed;
        }
        else
        {
            helthbarEffect.fillAmount = helthbar.fillAmount;
        }
        helthbar2.fillAmount = healt / maxhealt;
        if (helthbarEffect2.fillAmount > helthbar2.fillAmount)
        {
            helthbar2.fillAmount -= healtspeed;
        }
        else
        {
            helthbarEffect2.fillAmount = helthbar2.fillAmount;
        }
        if (healt < 0)
        {
            healt = 0;
        }
        h = healt;
        PlayerPrefs.SetFloat("HP", healt);
        PlayerPrefs.Save();
        text1.text = healt.ToString();
        a4.SetActive(a1);
        if(healt <= 0 && a1 == false)
        {
            a1 = true;
        }
        if(playerController.language == 0)
        {
            text2.text = "You died";
            text3.text = "Respawn";
            text4.text = "Main menu";
        }
        else
        {
            text2.text = "Вы умерли";
            text3.text = "Возродиться";
            text4.text = "Главное меню";
        }
    }
    public void Death2()
    {
        a1 = false;
        gameObject.transform.position = new Vector3(8, 2, 0);
        healt = maxhealt;
        
        if(a3 >= 250)
        {
            trader1.money -= 250;
        }
        else
        {
            trader1.money -= a3;
        }
    }
    public void Death3()
    {
        a1 = false;
        gameObject.transform.position = new Vector3(8, 2, 0);
        healt = maxhealt;
        if (a3 >= 250)
        {
            trader1.money -= 250;
        }
        else
        {
            trader1.money -= a3;
        }
        PlayerPrefs.Save();
        SceneManager.LoadScene(0);
    }
}
