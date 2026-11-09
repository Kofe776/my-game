using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public PlayerController playerController;
    public Image level;
    public Image levelEffect;
    public float maxlevelpoint;
    public static float levelpoint;
    public int PlayerLevel;
    public float levelspeed;
    public float l;
    public float levelpoint2;
    public float maxlevelpoint2;
    public Text text1;
    public Skills skills;
    public Text text2;
    public float textTime;
    public float textTimeStart;
    // Start is called before the first frame update
    void Start()
    {
        textTime = textTimeStart;
        playerController = gameObject.GetComponent<PlayerController>();
        skills = gameObject.GetComponent<Skills>();
        if(PlayerPrefs.HasKey("level"))
        {
            PlayerLevel = PlayerPrefs.GetInt("level");
        }
        else
        {
            PlayerLevel = 1;
        }
        if (PlayerPrefs.HasKey("maxlevelpoint2"))
        {
            maxlevelpoint = PlayerPrefs.GetFloat("maxlevelpoint2");
        }
        else
        {
            maxlevelpoint = 400;
        }
        if (PlayerPrefs.HasKey("maxlevelpoint"))
        {
            maxlevelpoint2 = PlayerPrefs.GetFloat("maxlevelpoint");
        }
        else
        {
            maxlevelpoint2 = 0;
        }
        if (PlayerPrefs.HasKey("levelpoint"))
        {
            levelpoint2 = PlayerPrefs.GetFloat("levelpoint");
        }
        else
        {
            levelpoint2 = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        textTime -= Time.deltaTime;
        levelpoint = levelpoint2 - maxlevelpoint2;
        if(levelpoint >= maxlevelpoint)
        {
            maxlevelpoint2 += maxlevelpoint;
            PlayerLevel += 1;
            maxlevelpoint += 100;
            skills.skillPoints += 1;
        }
        l = levelpoint;
        PlayerPrefs.SetInt("level", PlayerLevel);
        PlayerPrefs.SetFloat("maxlevelpoint", maxlevelpoint2);
        PlayerPrefs.SetFloat("levelpoint", levelpoint2);
        PlayerPrefs.SetFloat("maxlevelpoint2", maxlevelpoint);
        PlayerPrefs.Save();
        level.fillAmount = levelpoint / maxlevelpoint;
        if (levelEffect.fillAmount > level.fillAmount)
        {
            level.fillAmount -= levelspeed;
        }
        else
        {
            levelEffect.fillAmount = level.fillAmount;
        }
        if(playerController.language == 0)
        {
            text1.text = "lvl. " + PlayerLevel.ToString();
        }
        else
        {
            text1.text = "Ур. " + PlayerLevel.ToString();
        }
        if(textTime <= 0)
        {
            text2.text = "";
        }
    }
}
