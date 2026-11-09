using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdsMenu : MonoBehaviour
{
    public PlayerController playerController;
    public int menuads3;
    public Text text2;
    public float menuads2;
    public bool menuads4;
    public float menuads6;
    public float menuads7;
    public float menuads8;
    public float menuads9;
    public float menuads10;
    public float menuads11;
    public GameObject a1;
    public GameObject a2;
    public bool a3;
    public bool a4;
    public GameObject b1;
    public GameObject b2;
    // Start is called before the first frame update
    void Start()
    {
        playerController = gameObject.GetComponent<PlayerController>();
        menuads3 = Random.Range(0, 2);
        a3 = false;
        a4 = false;
        if(PlayerPrefs.HasKey("bonusTime"))
        {
            menuads2 = PlayerPrefs.GetFloat("bonusTime");
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.language == 0)
        {
            b1.SetActive(true);
            b2.SetActive(false);
        }
        else
        {
            b1.SetActive(false);
            b2.SetActive(true);
        }
        a1.SetActive(a3);
        a2.SetActive(a4);
        menuads2 -= Time.deltaTime;
        menuads7 = (int)menuads2;
        menuads8 = menuads7 / 60;
        menuads9 = (int)menuads8;
        menuads10 = menuads7 % 60;
        menuads11 = (int)menuads10;
        if(menuads2 <= 0)
        {
            text2.text = "";
            menuads4 = false;
        }
        else
        {
            menuads4 = true;
            text2.text = menuads9.ToString() + ":" + menuads11.ToString();
        }
        PlayerPrefs.SetFloat("bonusTime", menuads2);
        PlayerPrefs.Save();
    }
    public void a1menuOff()
    {
        a3 = false;
    }
    public void a2menuOff()
    {
        a4 = false;
    }
}
