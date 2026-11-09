using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsMenu : MonoBehaviour
{
    public bool on;
    public GameObject sMenu;
    public GameObject sMenu3;
    public bool on3;
    public Level level1;
    public Skills skills1;
    public trader trader1;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public PlayerController PCon;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
        on3 = false;
        level1 = gameObject.GetComponent<Level>();
        skills1 = gameObject.GetComponent<Skills>();
        trader1 = gameObject.GetComponent<trader>();
        PCon = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        sMenu.SetActive(on);
        sMenu3.SetActive(on3);
        if(PCon.language == 0)
        {
            text1.text = "SKILL POINTS: " + skills1.skillPoints.ToString();
            text2.text = "Attack";
            text3.text = "Protection";
            text4.text = "Resources";
            text5.text = "RESET SKILLS";
            text6.text = "or";
        }
        else
        {
            text1.text = "ОЧКИ НАВЫКОВ: " + skills1.skillPoints.ToString();
            text2.text = "Атака";
            text3.text = "Защита";
            text4.text = "Ресурсы";
            text5.text = "СБРОСИТЬ НАВЫКИ";
            text6.text = "или";
        }
        
    }
    public void on2()
    {
        on = true;
    }
    public void off()
    {
        on = false;
    }
    public void on4()
    {
        on3 = true;
    }
    public void off4()
    {
        on3 = false;
    }
    public void resetSkills()
    {
        if(trader1.money >= 2000)
        {
            trader1.money -= 2000;
            on3 = false;
            skills1.skillPoints = level1.PlayerLevel - 1;
            skills1.level = 0;
            skills1.level2 = 0;
            skills1.level3 = 0;
            skills1.level4 = 0;
            skills1.level5 = 0;
            skills1.level6 = 0;
            skills1.level7 = 0;
            skills1.level8 = 0;
            skills1.levelB = 0;
            skills1.levelB2 = 0;
            skills1.levelB3 = 0;
            skills1.levelB4 = 0;
            skills1.levelB5 = 0;
            skills1.levelB6 = 0;
            skills1.levelB7 = 0;
            skills1.levelB8 = 0;
            skills1.levelC = 0;
            skills1.levelC2 = 0;
            skills1.levelC3 = 0;
            skills1.levelC4 = 0;
            skills1.levelC5 = 0;
            skills1.levelC6 = 0;
        }
    }
}
