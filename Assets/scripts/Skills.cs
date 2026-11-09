using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skills : MonoBehaviour
{
    public int skillPoints;
    public PlayerController PCon;
    public int level;
    public int level2;
    public int level3;
    public int level4;
    public int level5;
    public int level6;
    public int level7;
    public int level8;
    public int levelB;
    public int levelB2;
    public int levelB3;
    public int levelB4;
    public int levelB5;
    public int levelB6;
    public int levelB7;
    public int levelB8;
    public int levelC;
    public int levelC2;
    public int levelC3;
    public int levelC4;
    public int levelC5;
    public int levelC6;
    public int a;
    public int a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject a5;
    public GameObject a6;
    public GameObject a7;
    public GameObject a8;
    public GameObject a9;
    public GameObject a10;
    public GameObject a11;
    public GameObject a12;
    public GameObject a13;
    public bool on;
    public bool on2;
    public bool on3;
    public GameObject b;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject c;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject c8;
    public GameObject d;
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    public GameObject d5;
    public GameObject d6;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    public GameObject star6;
    public GameObject star7;
    public GameObject star8;
    public GameObject star9;
    public GameObject star10;
    public GameObject star11;
    public GameObject star12;
    public GameObject star13;
    public GameObject star14;
    public GameObject star15;
    public GameObject star16;
    public GameObject star17;
    public GameObject star18;
    public GameObject star19;
    public GameObject star20;
    public GameObject star21;
    public GameObject star22;
    public GameObject starB1;
    public GameObject starB2;
    public GameObject starB3;
    public GameObject starB4;
    public GameObject starB5;
    public GameObject starB6;
    public GameObject starB7;
    public GameObject starB8;
    public GameObject starB9;
    public GameObject starB10;
    public GameObject starB11;
    public GameObject starB12;
    public GameObject starB13;
    public GameObject starB14;
    public GameObject starB15;
    public GameObject starB16;
    public GameObject starB17;
    public GameObject starB18;
    public GameObject starB19;
    public GameObject starB20;
    public GameObject starC1;
    public GameObject starC2;
    public GameObject starC3;
    public GameObject starC4;
    public GameObject starC5;
    public GameObject starC6;
    public GameObject starC7;
    public GameObject starC8;
    public GameObject starC9;
    public GameObject starC10;
    public GameObject starC11;
    public GameObject starC12;
    public GameObject starC13;
    public GameObject starC14;
    public GameObject starC15;
    public GameObject starC16;
    public GameObject starC17;
    public GameObject starC18;
    public Level Level1;
    public GameObject skillMenuA;
    public GameObject skillMenuA2;
    public GameObject skillMenuA3;
    public GameObject skillMenuA4;
    public GameObject skillMenuA5;
    public GameObject skillMenuA6;
    public GameObject skillMenuA7;
    public GameObject skillMenuA8;
    public GameObject skillMenuB;
    public GameObject skillMenuB2;
    public GameObject skillMenuB3;
    public GameObject skillMenuB4;
    public GameObject skillMenuB5;
    public GameObject skillMenuB6;
    public GameObject skillMenuB7;
    public GameObject skillMenuB8;
    public GameObject skillMenuC;
    public GameObject skillMenuC2;
    public GameObject skillMenuC3;
    public GameObject skillMenuC4;
    public GameObject skillMenuC5;
    public GameObject skillMenuC6;
    public GameObject skillMenuARU;
    public GameObject skillMenuA2RU;
    public GameObject skillMenuA3RU;
    public GameObject skillMenuA4RU;
    public GameObject skillMenuA5RU;
    public GameObject skillMenuA6RU;
    public GameObject skillMenuA7RU;
    public GameObject skillMenuA8RU;
    public GameObject skillMenuBRU;
    public GameObject skillMenuB2RU;
    public GameObject skillMenuB3RU;
    public GameObject skillMenuB4RU;
    public GameObject skillMenuB5RU;
    public GameObject skillMenuB6RU;
    public GameObject skillMenuB7RU;
    public GameObject skillMenuB8RU;
    public GameObject skillMenuCRU;
    public GameObject skillMenuC2RU;
    public GameObject skillMenuC3RU;
    public GameObject skillMenuC4RU;
    public GameObject skillMenuC5RU;
    public GameObject skillMenuC6RU;
    public GameObject Abutton;
    public GameObject Abutton2;
    public GameObject Abutton3;
    public GameObject Abutton4;
    public GameObject Abutton5;
    public GameObject Abutton6;
    public GameObject Abutton7;
    public GameObject Abutton8;
    public GameObject AbuttonRU;
    public GameObject Abutton2RU;
    public GameObject Abutton3RU;
    public GameObject Abutton4RU;
    public GameObject Abutton5RU;
    public GameObject Abutton6RU;
    public GameObject Abutton7RU;
    public GameObject Abutton8RU;
    public GameObject Bbutton;
    public GameObject BbuttonRU;
    public GameObject Bbutton2;
    public GameObject BbuttonRU2;
    public GameObject Bbutton3;
    public GameObject BbuttonRU3;
    public GameObject Bbutton4;
    public GameObject BbuttonRU4;
    public GameObject Bbutton5;
    public GameObject BbuttonRU5;
    public GameObject Bbutton6;
    public GameObject BbuttonRU6;
    public GameObject Cbutton;
    public GameObject Cbutton2;
    public GameObject Cbutton3;
    public GameObject Cbutton4;
    public GameObject Cbutton5;
    public GameObject Cbutton6;
    public GameObject Cbutton7;
    public GameObject Cbutton8;
    public GameObject CbuttonRU;
    public GameObject Cbutton2RU;
    public GameObject Cbutton3RU;
    public GameObject Cbutton4RU;
    public GameObject Cbutton5RU;
    public GameObject Cbutton6RU;
    public GameObject Cbutton7RU;
    public GameObject Cbutton8RU;
    public GameObject Dbutton;
    public GameObject DbuttonRU;
    public GameObject Dbutton2;
    public GameObject DbuttonRU2;
    public GameObject Dbutton3;
    public GameObject DbuttonRU3;
    public GameObject Dbutton4;
    public GameObject DbuttonRU4;
    public GameObject Dbutton5;
    public GameObject DbuttonRU5;
    public GameObject Dbutton6;
    public GameObject DbuttonRU6;
    public GameObject Ebutton;
    public GameObject Ebutton2;
    public GameObject Ebutton3;
    public GameObject Ebutton4;
    public GameObject Ebutton5;
    public GameObject Ebutton6;
    public GameObject EbuttonRU;
    public GameObject Ebutton2RU;
    public GameObject Ebutton3RU;
    public GameObject Ebutton4RU;
    public GameObject Ebutton5RU;
    public GameObject Ebutton6RU;
    public GameObject Fbutton;
    public GameObject Fbutton2;
    public GameObject Fbutton3;
    public GameObject Fbutton4;
    public GameObject FbuttonRU;
    public GameObject FbuttonRU2;
    public GameObject FbuttonRU3;
    public GameObject FbuttonRU4;
    public GameObject AbuttonOFF1;
    public GameObject AbuttonOFF2;
    public GameObject AbuttonOFF3;
    public GameObject AbuttonOFF4;
    public GameObject AbuttonOFF5;
    public GameObject AbuttonOFF6;
    public GameObject AbuttonOFF7;
    public GameObject AbuttonOFF8;
    public GameObject AbuttonOFF1RU;
    public GameObject AbuttonOFF2RU;
    public GameObject AbuttonOFF3RU;
    public GameObject AbuttonOFF4RU;
    public GameObject AbuttonOFF5RU;
    public GameObject AbuttonOFF6RU;
    public GameObject AbuttonOFF7RU;
    public GameObject AbuttonOFF8RU;
    public GameObject BbuttonOFF1;
    public GameObject BbuttonOFF2;
    public GameObject BbuttonOFF3;
    public GameObject BbuttonOFF4;
    public GameObject BbuttonOFF5;
    public GameObject BbuttonOFF6;
    public GameObject BbuttonOFF7;
    public GameObject BbuttonOFF8;
    public GameObject BbuttonOFF1RU;
    public GameObject BbuttonOFF2RU;
    public GameObject BbuttonOFF3RU;
    public GameObject BbuttonOFF4RU;
    public GameObject BbuttonOFF5RU;
    public GameObject BbuttonOFF6RU;
    public GameObject BbuttonOFF7RU;
    public GameObject BbuttonOFF8RU;
    public GameObject CbuttonOFF1;
    public GameObject CbuttonOFF2;
    public GameObject CbuttonOFF3;
    public GameObject CbuttonOFF4;
    public GameObject CbuttonOFF5;
    public GameObject CbuttonOFF6;
    public GameObject CbuttonOFF1RU;
    public GameObject CbuttonOFF2RU;
    public GameObject CbuttonOFF3RU;
    public GameObject CbuttonOFF4RU;
    public GameObject CbuttonOFF5RU;
    public GameObject CbuttonOFF6RU;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        PCon = gameObject.GetComponent<PlayerController>();
        Level1 = gameObject.GetComponent<Level>();
        training1 = gameObject.GetComponent<training>();
        on = true;
        on2 = false;
        on3 = false;
        if (PlayerPrefs.HasKey("skillpoints"))
        {
            skillPoints = PlayerPrefs.GetInt("skillpoints");
        }
        else
        {
            skillPoints = 0;
        }
        if (PlayerPrefs.HasKey("levela1"))
        {
            level = PlayerPrefs.GetInt("levela1");
        }
        else
        {
            level = 0;
        }
        if (PlayerPrefs.HasKey("levela2"))
        {
            level2 = PlayerPrefs.GetInt("levela2");
        }
        else
        {
            level2 = 0;
        }
        if (PlayerPrefs.HasKey("levela3"))
        {
            level3 = PlayerPrefs.GetInt("levela3");
        }
        else
        {
            level3 = 0;
        }
        if (PlayerPrefs.HasKey("levela4"))
        {
            level4 = PlayerPrefs.GetInt("levela4");
        }
        else
        {
            level4 = 0;
        }
        if (PlayerPrefs.HasKey("levela5"))
        {
            level5 = PlayerPrefs.GetInt("levela5");
        }
        else
        {
            level5 = 0;
        }
        if (PlayerPrefs.HasKey("levela6"))
        {
            level6 = PlayerPrefs.GetInt("levela6");
        }
        else
        {
            level6 = 0;
        }
        if (PlayerPrefs.HasKey("levela7"))
        {
            level7 = PlayerPrefs.GetInt("levela7");
        }
        else
        {
            level7 = 0;
        }
        if (PlayerPrefs.HasKey("levela8"))
        {
            level8 = PlayerPrefs.GetInt("levela8");
        }
        else
        {
            level8 = 0;
        }
        if (PlayerPrefs.HasKey("levelb1"))
        {
            levelB = PlayerPrefs.GetInt("levelb1");
        }
        else
        {
            levelB = 0;
        }
        if (PlayerPrefs.HasKey("levelb2"))
        {
            levelB2 = PlayerPrefs.GetInt("levelb2");
        }
        else
        {
            levelB2 = 0;
        }
        if (PlayerPrefs.HasKey("levelb3"))
        {
            levelB3 = PlayerPrefs.GetInt("levelb3");
        }
        else
        {
            levelB3 = 0;
        }
        if (PlayerPrefs.HasKey("levelb4"))
        {
            levelB4 = PlayerPrefs.GetInt("levelb4");
        }
        else
        {
            levelB4 = 0;
        }
        if (PlayerPrefs.HasKey("levelb5"))
        {
            levelB5 = PlayerPrefs.GetInt("levelb5");
        }
        else
        {
            levelB5 = 0;
        }
        if (PlayerPrefs.HasKey("levelb6"))
        {
            levelB6 = PlayerPrefs.GetInt("levelb6");
        }
        else
        {
            levelB6 = 0;
        }
        if (PlayerPrefs.HasKey("levelb7"))
        {
            levelB7 = PlayerPrefs.GetInt("levelb7");
        }
        else
        {
            levelB7 = 0;
        }
        if (PlayerPrefs.HasKey("levelb8"))
        {
            levelB8 = PlayerPrefs.GetInt("levelb8");
        }
        else
        {
            levelB8 = 0;
        }
        if (PlayerPrefs.HasKey("levelc1"))
        {
            levelC = PlayerPrefs.GetInt("levelc1");
        }
        else
        {
            levelC = 0;
        }
        if (PlayerPrefs.HasKey("levelc2"))
        {
            levelC2 = PlayerPrefs.GetInt("levelc2");
        }
        else
        {
            levelC2 = 0;
        }
        if (PlayerPrefs.HasKey("levelc3"))
        {
            levelC3 = PlayerPrefs.GetInt("levelc3");
        }
        else
        {
            levelC3 = 0;
        }
        if (PlayerPrefs.HasKey("levelc4"))
        {
            levelC4 = PlayerPrefs.GetInt("levelc4");
        }
        else
        {
            levelC4 = 0;
        }
        if (PlayerPrefs.HasKey("levelc5"))
        {
            levelC5 = PlayerPrefs.GetInt("levelc5");
        }
        else
        {
            levelC5 = 0;
        }
        if (PlayerPrefs.HasKey("levelc6"))
        {
            levelC6 = PlayerPrefs.GetInt("levelc6");
        }
        else
        {
            levelC6 = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("levela1", level);
        PlayerPrefs.SetInt("levela2", level2);
        PlayerPrefs.SetInt("levela3", level3);
        PlayerPrefs.SetInt("levela4", level4);
        PlayerPrefs.SetInt("levela5", level5);
        PlayerPrefs.SetInt("levela6", level6);
        PlayerPrefs.SetInt("levela7", level7);
        PlayerPrefs.SetInt("levela8", level8);
        PlayerPrefs.SetInt("levelb1", levelB);
        PlayerPrefs.SetInt("levelb2", levelB2);
        PlayerPrefs.SetInt("levelb3", levelB3);
        PlayerPrefs.SetInt("levelb4", levelB4);
        PlayerPrefs.SetInt("levelb5", levelB5);
        PlayerPrefs.SetInt("levelb6", levelB6);
        PlayerPrefs.SetInt("levelb7", levelB7);
        PlayerPrefs.SetInt("levelb8", levelB8);
        PlayerPrefs.SetInt("levelc1", levelC);
        PlayerPrefs.SetInt("levelc2", levelC2);
        PlayerPrefs.SetInt("levelc3", levelC3);
        PlayerPrefs.SetInt("levelc4", levelC4);
        PlayerPrefs.SetInt("levelc5", levelC5);
        PlayerPrefs.SetInt("levelc6", levelC6);
        if (level < 3)
        {
            if(skillPoints > 0)
            {
                Abutton.SetActive(true);
                AbuttonRU.SetActive(true);
                AbuttonOFF1.SetActive(false);
                AbuttonOFF1RU.SetActive(false);
            }
            else
            {
                Abutton.SetActive(false);
                AbuttonRU.SetActive(false);
                AbuttonOFF1.SetActive(true);
                AbuttonOFF1RU.SetActive(true);
            }
        }
        else
        {
            Abutton.SetActive(false);
            AbuttonRU.SetActive(false);
            AbuttonOFF1.SetActive(false);
            AbuttonOFF1RU.SetActive(false);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Bbutton.SetActive(false);
            BbuttonRU.SetActive(false);
            if (level2 < 3)
            {
                if(skillPoints > 0)
                {
                    Abutton2.SetActive(true);
                    Abutton2RU.SetActive(true);
                    AbuttonOFF2.SetActive(false);
                    AbuttonOFF2RU.SetActive(false);
                }
                else
                {
                    Abutton2.SetActive(false);
                    Abutton2RU.SetActive(false);
                    AbuttonOFF2.SetActive(true);
                    AbuttonOFF2RU.SetActive(true);
                }
            }
            else
            {
                Abutton2.SetActive(false);
                Abutton2RU.SetActive(false);
                AbuttonOFF2.SetActive(false);
                AbuttonOFF2RU.SetActive(false);
            }
        }
        else
        {
            AbuttonOFF2.SetActive(false);
            AbuttonOFF2RU.SetActive(false);
            Abutton2.SetActive(false);
            Abutton2RU.SetActive(false);
            Bbutton.SetActive(true);
            BbuttonRU.SetActive(true);
        }
        if (level3 < 3)
        {
            if (skillPoints > 0)
            {
                Abutton3.SetActive(true);
                Abutton3RU.SetActive(true);
                AbuttonOFF3.SetActive(false);
                AbuttonOFF3RU.SetActive(false);
            }
            else
            {
                Abutton3.SetActive(false);
                Abutton3RU.SetActive(false);
                AbuttonOFF3.SetActive(true);
                AbuttonOFF3RU.SetActive(true);
            }
        }
        else
        {
            Abutton3.SetActive(false);
            Abutton3RU.SetActive(false);
            AbuttonOFF3.SetActive(false);
            AbuttonOFF3RU.SetActive(false);
        }
        if (Level1.PlayerLevel >= 15)
        {
            Bbutton2.SetActive(false);
            BbuttonRU2.SetActive(false);
            if (level4 < 3)
            {
                if (skillPoints > 0)
                {
                    Abutton4.SetActive(true);
                    Abutton4RU.SetActive(true);
                    AbuttonOFF4.SetActive(false);
                    AbuttonOFF4RU.SetActive(false);
                }
                else
                {
                    Abutton4.SetActive(false);
                    Abutton4RU.SetActive(false);
                    AbuttonOFF4.SetActive(true);
                    AbuttonOFF4RU.SetActive(true);
                }
            }
            else
            {
                Abutton4.SetActive(false);
                Abutton4RU.SetActive(false);
                AbuttonOFF4.SetActive(false);
                AbuttonOFF4RU.SetActive(false);
            }
        }
        else
        {
            Abutton4.SetActive(false);
            Abutton4RU.SetActive(false);
            Bbutton2.SetActive(true);
            BbuttonRU2.SetActive(true);
            AbuttonOFF4.SetActive(false);
            AbuttonOFF4RU.SetActive(false);
        }
        if (Level1.PlayerLevel >= 20)
        {
            Bbutton3.SetActive(false);
            BbuttonRU3.SetActive(false);
            if (level5 < 3)
            {
                if (skillPoints > 0)
                {
                    Abutton5.SetActive(true);
                    Abutton5RU.SetActive(true);
                    AbuttonOFF5.SetActive(false);
                    AbuttonOFF5RU.SetActive(false);
                }
                else
                {
                    Abutton5.SetActive(false);
                    Abutton5RU.SetActive(false);
                    AbuttonOFF5.SetActive(true);
                    AbuttonOFF5RU.SetActive(true);
                }
            }
            else
            {
                Abutton5.SetActive(false);
                Abutton5RU.SetActive(false);
                AbuttonOFF5.SetActive(false);
                AbuttonOFF5RU.SetActive(false);
            }
        }
        else
        {
            AbuttonOFF5.SetActive(false);
            AbuttonOFF5RU.SetActive(false);
            Abutton5.SetActive(false);
            Abutton5RU.SetActive(false);
            Bbutton3.SetActive(true);
            BbuttonRU3.SetActive(true);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Bbutton4.SetActive(false);
            BbuttonRU4.SetActive(false);
            if (level6 < 3)
            {
                if (skillPoints > 0)
                {
                    Abutton6.SetActive(true);
                    Abutton6RU.SetActive(true);
                    AbuttonOFF6.SetActive(false);
                    AbuttonOFF6RU.SetActive(false);
                }
                else
                {
                    Abutton6.SetActive(false);
                    Abutton6RU.SetActive(false);
                    AbuttonOFF6.SetActive(true);
                    AbuttonOFF6RU.SetActive(true);
                }
            }
            else
            {
                Abutton6.SetActive(false);
                Abutton6RU.SetActive(false);
                AbuttonOFF6.SetActive(false);
                AbuttonOFF6RU.SetActive(false);
            }
        }
        else
        {
            AbuttonOFF6.SetActive(false);
            AbuttonOFF6RU.SetActive(false);
            Abutton6.SetActive(false);
            Abutton6RU.SetActive(false);
            Bbutton4.SetActive(true);
            BbuttonRU4.SetActive(true);
        }
        if (Level1.PlayerLevel >= 25)
        {
            Bbutton5.SetActive(false);
            BbuttonRU5.SetActive(false);
            if (level7 < 2)
            {
                if (skillPoints > 0)
                {
                    Abutton7.SetActive(true);
                    Abutton7RU.SetActive(true);
                    AbuttonOFF7.SetActive(false);
                    AbuttonOFF7RU.SetActive(false);
                }
                else
                {
                    Abutton7.SetActive(false);
                    Abutton7RU.SetActive(false);
                    AbuttonOFF7.SetActive(true);
                    AbuttonOFF7RU.SetActive(true);
                }
            }
            else
            {
                Abutton7.SetActive(false);
                Abutton7RU.SetActive(false);
                AbuttonOFF7.SetActive(false);
                AbuttonOFF7RU.SetActive(false);
            }
        }
        else
        {
            AbuttonOFF7.SetActive(false);
            AbuttonOFF7RU.SetActive(false);
            Abutton7.SetActive(false);
            Abutton7RU.SetActive(false);
            Bbutton5.SetActive(true);
            BbuttonRU5.SetActive(true);
        }
        if (Level1.PlayerLevel >= 25)
        {
            Bbutton6.SetActive(false);
            BbuttonRU6.SetActive(false);
            if (level8 < 2)
            {
                if (skillPoints > 0)
                {
                    Abutton8.SetActive(true);
                    Abutton8RU.SetActive(true);
                    AbuttonOFF8.SetActive(false);
                    AbuttonOFF8RU.SetActive(false);
                }
                else
                {
                    Abutton8.SetActive(false);
                    Abutton8RU.SetActive(false);
                    AbuttonOFF8.SetActive(true);
                    AbuttonOFF8RU.SetActive(true);
                }
            }
            else
            {
                Abutton8.SetActive(false);
                Abutton8RU.SetActive(false);
                AbuttonOFF8.SetActive(false);
                AbuttonOFF8RU.SetActive(false);
            }
        }
        else
        {
            AbuttonOFF8.SetActive(false);
            AbuttonOFF8RU.SetActive(false);
            Abutton8.SetActive(false);
            Abutton8RU.SetActive(false);
            Bbutton6.SetActive(true);
            BbuttonRU6.SetActive(true);
        }
        if(levelB < 3)
        {
            if (skillPoints > 0)
            {
                Cbutton.SetActive(true);
                CbuttonRU.SetActive(true);
                BbuttonOFF1.SetActive(false);
                BbuttonOFF1RU.SetActive(false);
            }
            else
            {
                Cbutton.SetActive(false);
                CbuttonRU.SetActive(false);
                BbuttonOFF1.SetActive(true);
                BbuttonOFF1RU.SetActive(true);
            }
        }
        else
        {
            Cbutton.SetActive(false);
            CbuttonRU.SetActive(false);
            BbuttonOFF1.SetActive(false);
            BbuttonOFF1RU.SetActive(false);
        }
        if (levelB2 < 3)
        {
            if (skillPoints > 0)
            {
                Cbutton2.SetActive(true);
                Cbutton2RU.SetActive(true);
                BbuttonOFF2.SetActive(false);
                BbuttonOFF2RU.SetActive(false);
            }
            else
            {
                Cbutton2.SetActive(false);
                Cbutton2RU.SetActive(false);
                BbuttonOFF2.SetActive(true);
                BbuttonOFF2RU.SetActive(true);
            }
        }
        else
        {
            Cbutton2.SetActive(false);
            Cbutton2RU.SetActive(false);
            BbuttonOFF2.SetActive(false);
            BbuttonOFF2RU.SetActive(false);
        }
        if(Level1.PlayerLevel >= 5)
        {
            Dbutton.SetActive(false);
            DbuttonRU.SetActive(false);
            if (levelB3 < 3)
            {
                if (skillPoints > 0)
                {
                    Cbutton3.SetActive(true);
                    Cbutton3RU.SetActive(true);
                    BbuttonOFF3.SetActive(false);
                    BbuttonOFF3RU.SetActive(false);
                }
                else
                {
                    Cbutton3.SetActive(false);
                    Cbutton3RU.SetActive(false);
                    BbuttonOFF3.SetActive(true);
                    BbuttonOFF3RU.SetActive(true);
                }
            }
            else
            {
                Cbutton3.SetActive(false);
                Cbutton3RU.SetActive(false);
                BbuttonOFF3.SetActive(false);
                BbuttonOFF3RU.SetActive(false);
            }
        }
        else
        {
            BbuttonOFF3.SetActive(false);
            BbuttonOFF3RU.SetActive(false);
            Cbutton3.SetActive(false);
            Cbutton3RU.SetActive(false);
            Dbutton.SetActive(true);
            DbuttonRU.SetActive(true);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Dbutton2.SetActive(false);
            DbuttonRU2.SetActive(false);
            if (levelB4 < 2)
            {
                if (skillPoints > 0)
                {
                    Cbutton4.SetActive(true);
                    Cbutton4RU.SetActive(true);
                    BbuttonOFF4.SetActive(false);
                    BbuttonOFF4RU.SetActive(false);
                }
                else
                {
                    Cbutton4.SetActive(false);
                    Cbutton4RU.SetActive(false);
                    BbuttonOFF4.SetActive(true);
                    BbuttonOFF4RU.SetActive(true);
                }
            }
            else
            {
                Cbutton4.SetActive(false);
                Cbutton4RU.SetActive(false);
                BbuttonOFF4.SetActive(false);
                BbuttonOFF4RU.SetActive(false);
            }
        }
        else
        {
            BbuttonOFF4.SetActive(false);
            BbuttonOFF4RU.SetActive(false);
            Cbutton4.SetActive(false);
            Cbutton4RU.SetActive(false);
            Dbutton2.SetActive(true);
            DbuttonRU2.SetActive(true);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Dbutton3.SetActive(false);
            DbuttonRU3.SetActive(false);
            if (levelB5 < 2)
            {
                if (skillPoints > 0)
                {
                    Cbutton5.SetActive(true);
                    Cbutton5RU.SetActive(true);
                    BbuttonOFF5.SetActive(false);
                    BbuttonOFF5RU.SetActive(false);
                }
                else
                {
                    Cbutton5.SetActive(false);
                    Cbutton5RU.SetActive(false);
                    BbuttonOFF5.SetActive(true);
                    BbuttonOFF5RU.SetActive(true);
                }
            }
            else
            {
                Cbutton5.SetActive(false);
                Cbutton5RU.SetActive(false);
                BbuttonOFF5.SetActive(false);
                BbuttonOFF5RU.SetActive(false);
            }
        }
        else
        {
            BbuttonOFF5.SetActive(false);
            BbuttonOFF5RU.SetActive(false);
            Cbutton5.SetActive(false);
            Cbutton5RU.SetActive(false);
            Dbutton3.SetActive(true);
            DbuttonRU3.SetActive(true);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Dbutton4.SetActive(false);
            DbuttonRU4.SetActive(false);
            if (levelB6 < 3)
            {
                if (skillPoints > 0)
                {
                    Cbutton6.SetActive(true);
                    Cbutton6RU.SetActive(true);
                    BbuttonOFF6.SetActive(false);
                    BbuttonOFF6RU.SetActive(false);
                }
                else
                {
                    Cbutton6.SetActive(false);
                    Cbutton6RU.SetActive(false);
                    BbuttonOFF6.SetActive(true);
                    BbuttonOFF6RU.SetActive(true);
                }
            }
            else
            {

                Cbutton6.SetActive(false);
                Cbutton6RU.SetActive(false);
                BbuttonOFF6.SetActive(false);
                BbuttonOFF6RU.SetActive(false);
            }
        }
        else
        {
            BbuttonOFF6.SetActive(false);
            BbuttonOFF6RU.SetActive(false);
            Cbutton6.SetActive(false);
            Cbutton6RU.SetActive(false);
            Dbutton4.SetActive(true);
            DbuttonRU4.SetActive(true);
        }
        if (Level1.PlayerLevel >= 25)
        {
            Dbutton5.SetActive(false);
            DbuttonRU5.SetActive(false);
            if (levelB7 < 2)
            {
                if (skillPoints > 0)
                {
                    Cbutton7.SetActive(true);
                    Cbutton7RU.SetActive(true);
                    BbuttonOFF7.SetActive(false);
                    BbuttonOFF7RU.SetActive(false);
                }
                else
                {
                    Cbutton7.SetActive(false);
                    Cbutton7RU.SetActive(false);
                    BbuttonOFF7.SetActive(true);
                    BbuttonOFF7RU.SetActive(true);
                }
            }
            else
            {
                BbuttonOFF7.SetActive(false);
                BbuttonOFF7RU.SetActive(false);
                Cbutton7.SetActive(false);
                Cbutton7RU.SetActive(false);
            }
        }
        else
        {
            BbuttonOFF7.SetActive(false);
            BbuttonOFF7RU.SetActive(false);
            Cbutton7.SetActive(false);
            Cbutton7RU.SetActive(false);
            Dbutton5.SetActive(true);
            DbuttonRU5.SetActive(true);
        }
        if (Level1.PlayerLevel >= 25)
        {
            Dbutton6.SetActive(false);
            DbuttonRU6.SetActive(false);
            if (levelB8 < 2)
            {
                if (skillPoints > 0)
                {
                    Cbutton8.SetActive(true);
                    Cbutton8RU.SetActive(true);
                    BbuttonOFF8.SetActive(false);
                    BbuttonOFF8RU.SetActive(false);
                }
                else
                {
                    Cbutton8.SetActive(false);
                    Cbutton8RU.SetActive(false);
                    BbuttonOFF8.SetActive(true);
                    BbuttonOFF8RU.SetActive(true);
                }
            }
            else
            {
                BbuttonOFF8.SetActive(false);
                BbuttonOFF8RU.SetActive(false);
                Cbutton8.SetActive(false);
                Cbutton8RU.SetActive(false);
            }
        }
        else
        {
            BbuttonOFF8.SetActive(false);
            BbuttonOFF8RU.SetActive(false);
            Cbutton8.SetActive(false);
            Cbutton8RU.SetActive(false);
            Dbutton6.SetActive(true);
            DbuttonRU6.SetActive(true);
        }
        if(levelC < 3)
        {
            if (skillPoints > 0)
            {
                Ebutton.SetActive(true);
                EbuttonRU.SetActive(true);
                CbuttonOFF1.SetActive(false);
                CbuttonOFF1RU.SetActive(false);
            }
            else
            {
                Ebutton.SetActive(false);
                EbuttonRU.SetActive(false);
                CbuttonOFF1.SetActive(true);
                CbuttonOFF1RU.SetActive(true);
            }
        }
        else
        {
            Ebutton.SetActive(false);
            EbuttonRU.SetActive(false);
            CbuttonOFF1.SetActive(false);
            CbuttonOFF1RU.SetActive(false);
        }
        if (levelC2 < 3)
        {
            if (skillPoints > 0)
            {
                Ebutton2.SetActive(true);
                Ebutton2RU.SetActive(true);
                CbuttonOFF2.SetActive(false);
                CbuttonOFF2RU.SetActive(false);
            }
            else
            {
                Ebutton2.SetActive(false);
                Ebutton2RU.SetActive(false);
                CbuttonOFF2.SetActive(true);
                CbuttonOFF2RU.SetActive(true);
            }
        }
        else
        {
            Ebutton2.SetActive(false);
            Ebutton2RU.SetActive(false);
            CbuttonOFF2.SetActive(false);
            CbuttonOFF2RU.SetActive(false);
        }
        if(Level1.PlayerLevel >= 7)
        {
            Fbutton.SetActive(false);
            FbuttonRU.SetActive(false);
            if (levelC3 < 3)
            {
                if (skillPoints > 0)
                {
                    Ebutton3.SetActive(true);
                    Ebutton3RU.SetActive(true);
                    CbuttonOFF3.SetActive(false);
                    CbuttonOFF3RU.SetActive(false);
                }
                else
                {
                    Ebutton3.SetActive(false);
                    Ebutton3RU.SetActive(false);
                    CbuttonOFF3.SetActive(true);
                    CbuttonOFF3RU.SetActive(true);
                }
            }
            else
            {
                CbuttonOFF3.SetActive(false);
                CbuttonOFF3RU.SetActive(false);
                Ebutton3.SetActive(false);
                Ebutton3RU.SetActive(false);
            }
        }
        else
        {
            CbuttonOFF3.SetActive(false);
            CbuttonOFF3RU.SetActive(false);
            Ebutton3.SetActive(false);
            Ebutton3RU.SetActive(false);
            Fbutton.SetActive(true);
            FbuttonRU.SetActive(true);
        }
        if (Level1.PlayerLevel >= 7)
        {
            Fbutton2.SetActive(false);
            FbuttonRU2.SetActive(false);
            if (levelC4 < 3)
            {
                if (skillPoints > 0)
                {
                    Ebutton4.SetActive(true);
                    Ebutton4RU.SetActive(true);
                    CbuttonOFF4.SetActive(false);
                    CbuttonOFF4RU.SetActive(false);
                }
                else
                {
                    Ebutton4.SetActive(false);
                    Ebutton4RU.SetActive(false);
                    CbuttonOFF4.SetActive(true);
                    CbuttonOFF4RU.SetActive(true);
                }
            }
            else
            {
                CbuttonOFF4.SetActive(false);
                CbuttonOFF4RU.SetActive(false);
                Ebutton4.SetActive(false);
                Ebutton4RU.SetActive(false);
            }
        }
        else
        {
            CbuttonOFF4.SetActive(false);
            CbuttonOFF4RU.SetActive(false);
            Ebutton4.SetActive(false);
            Ebutton4RU.SetActive(false);
            Fbutton2.SetActive(true);
            FbuttonRU2.SetActive(true);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Fbutton3.SetActive(false);
            FbuttonRU3.SetActive(false);
            if (levelC5 < 3)
            {
                if (skillPoints > 0)
                {
                    Ebutton5.SetActive(true);
                    Ebutton5RU.SetActive(true);
                    CbuttonOFF5.SetActive(false);
                    CbuttonOFF5RU.SetActive(false);
                }
                else
                {
                    Ebutton5.SetActive(false);
                    Ebutton5RU.SetActive(false);
                    CbuttonOFF5.SetActive(true);
                    CbuttonOFF5RU.SetActive(true);
                }
            }
            else
            {
                CbuttonOFF5.SetActive(false);
                CbuttonOFF5RU.SetActive(false);
                Ebutton5.SetActive(false);
                Ebutton5RU.SetActive(false);
            }
        }
        else
        {
            CbuttonOFF5.SetActive(false);
            CbuttonOFF5RU.SetActive(false);
            Ebutton5.SetActive(false);
            Ebutton5RU.SetActive(false);
            Fbutton3.SetActive(true);
            FbuttonRU3.SetActive(true);
        }
        if (Level1.PlayerLevel >= 10)
        {
            Fbutton4.SetActive(false);
            FbuttonRU4.SetActive(false);
            if (levelC6 < 3)
            {
                if (skillPoints > 0)
                {
                    Ebutton6.SetActive(true);
                    Ebutton6RU.SetActive(true);
                    CbuttonOFF6.SetActive(false);
                    CbuttonOFF6RU.SetActive(false);
                }
                else
                {
                    Ebutton6.SetActive(false);
                    Ebutton6RU.SetActive(false);
                    CbuttonOFF6.SetActive(true);
                    CbuttonOFF6RU.SetActive(true);
                }
            }
            else
            {
                CbuttonOFF6.SetActive(false);
                CbuttonOFF6RU.SetActive(false);
                Ebutton6.SetActive(false);
                Ebutton6RU.SetActive(false);
            }
        }
        else
        {
            CbuttonOFF6.SetActive(false);
            CbuttonOFF6RU.SetActive(false);
            Ebutton6.SetActive(false);
            Ebutton6RU.SetActive(false);
            Fbutton4.SetActive(true);
            FbuttonRU4.SetActive(true);
        }
        PlayerPrefs.SetInt("skillpoints", skillPoints);
        PlayerPrefs.Save();
        if(PCon.language == 0)
        {
            skillMenuARU.SetActive(false);
            skillMenuA2RU.SetActive(false);
            skillMenuA3RU.SetActive(false);
            skillMenuA4RU.SetActive(false);
            skillMenuA5RU.SetActive(false);
            skillMenuA6RU.SetActive(false);
            skillMenuA7RU.SetActive(false);
            skillMenuA8RU.SetActive(false);
            skillMenuBRU.SetActive(false);
            skillMenuB2RU.SetActive(false);
            skillMenuB3RU.SetActive(false);
            skillMenuB4RU.SetActive(false);
            skillMenuB5RU.SetActive(false);
            skillMenuB6RU.SetActive(false);
            skillMenuB7RU.SetActive(false);
            skillMenuB8RU.SetActive(false);
            skillMenuCRU.SetActive(false);
            skillMenuC2RU.SetActive(false);
            skillMenuC3RU.SetActive(false);
            skillMenuC4RU.SetActive(false);
            skillMenuC5RU.SetActive(false);
            skillMenuC6RU.SetActive(false);
            if (a == 0)
            {
                skillMenuB.SetActive(false);
                skillMenuB2.SetActive(false);
                skillMenuB3.SetActive(false);
                skillMenuB4.SetActive(false);
                skillMenuB5.SetActive(false);
                skillMenuB6.SetActive(false);
                skillMenuB7.SetActive(false);
                skillMenuB8.SetActive(false);
                skillMenuC.SetActive(false);
                skillMenuC2.SetActive(false);
                skillMenuC3.SetActive(false);
                skillMenuC4.SetActive(false);
                skillMenuC5.SetActive(false);
                skillMenuC6.SetActive(false);
                if (a2 == 0)
                {
                    skillMenuA.SetActive(true);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(false);
                }
                else if (a2 == 1)
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(true);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(false);
                }
                else if (a2 == 2)
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(true);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(false);
                }
                else if (a2 == 3)
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(true);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(false);
                }
                else if (a2 == 4)
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(true);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(false);
                }
                else if (a2 == 5)
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(true);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(false);
                }
                else if (a2 == 6)
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(true);
                    skillMenuA8.SetActive(false);
                }
                else
                {
                    skillMenuA.SetActive(false);
                    skillMenuA2.SetActive(false);
                    skillMenuA3.SetActive(false);
                    skillMenuA4.SetActive(false);
                    skillMenuA5.SetActive(false);
                    skillMenuA6.SetActive(false);
                    skillMenuA7.SetActive(false);
                    skillMenuA8.SetActive(true);
                }
            }
            else if (a == 1)
            {
                skillMenuA.SetActive(false);
                skillMenuA2.SetActive(false);
                skillMenuA3.SetActive(false);
                skillMenuA4.SetActive(false);
                skillMenuA5.SetActive(false);
                skillMenuA6.SetActive(false);
                skillMenuA7.SetActive(false);
                skillMenuA8.SetActive(false);
                skillMenuC.SetActive(false);
                skillMenuC2.SetActive(false);
                skillMenuC3.SetActive(false);
                skillMenuC4.SetActive(false);
                skillMenuC5.SetActive(false);
                skillMenuC6.SetActive(false);
                if (a2 == 0)
                {
                    skillMenuB.SetActive(true);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(false);
                }
                else if (a2 == 1)
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(true);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(false);
                }
                else if (a2 == 2)
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(true);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(false);
                }
                else if (a2 == 3)
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(true);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(false);
                }
                else if (a2 == 4)
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(true);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(false);
                }
                else if (a2 == 5)
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(true);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(false);
                }
                else if (a2 == 6)
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(true);
                    skillMenuB8.SetActive(false);
                }
                else
                {
                    skillMenuB.SetActive(false);
                    skillMenuB2.SetActive(false);
                    skillMenuB3.SetActive(false);
                    skillMenuB4.SetActive(false);
                    skillMenuB5.SetActive(false);
                    skillMenuB6.SetActive(false);
                    skillMenuB7.SetActive(false);
                    skillMenuB8.SetActive(true);
                }
            }
            else
            {
                skillMenuB.SetActive(false);
                skillMenuB2.SetActive(false);
                skillMenuB3.SetActive(false);
                skillMenuB4.SetActive(false);
                skillMenuB5.SetActive(false);
                skillMenuB6.SetActive(false);
                skillMenuB7.SetActive(false);
                skillMenuB8.SetActive(false);
                skillMenuA.SetActive(false);
                skillMenuA2.SetActive(false);
                skillMenuA3.SetActive(false);
                skillMenuA4.SetActive(false);
                skillMenuA5.SetActive(false);
                skillMenuA6.SetActive(false);
                skillMenuA7.SetActive(false);
                skillMenuA8.SetActive(false);
                if (a2 == 0)
                {
                    skillMenuC.SetActive(true);
                    skillMenuC2.SetActive(false);
                    skillMenuC3.SetActive(false);
                    skillMenuC4.SetActive(false);
                    skillMenuC5.SetActive(false);
                    skillMenuC6.SetActive(false);
                }
                else if (a2 == 1)
                {
                    skillMenuC.SetActive(false);
                    skillMenuC2.SetActive(true);
                    skillMenuC3.SetActive(false);
                    skillMenuC4.SetActive(false);
                    skillMenuC5.SetActive(false);
                    skillMenuC6.SetActive(false);
                }
                else if (a2 == 2)
                {
                    skillMenuC.SetActive(false);
                    skillMenuC2.SetActive(false);
                    skillMenuC3.SetActive(true);
                    skillMenuC4.SetActive(false);
                    skillMenuC5.SetActive(false);
                    skillMenuC6.SetActive(false);
                }
                else if (a2 == 3)
                {
                    skillMenuC.SetActive(false);
                    skillMenuC2.SetActive(false);
                    skillMenuC3.SetActive(false);
                    skillMenuC4.SetActive(true);
                    skillMenuC5.SetActive(false);
                    skillMenuC6.SetActive(false);
                }
                else if (a2 == 4)
                {
                    skillMenuC.SetActive(false);
                    skillMenuC2.SetActive(false);
                    skillMenuC3.SetActive(false);
                    skillMenuC4.SetActive(false);
                    skillMenuC5.SetActive(true);
                    skillMenuC6.SetActive(false);
                }
                else
                {
                    skillMenuC.SetActive(false);
                    skillMenuC2.SetActive(false);
                    skillMenuC3.SetActive(false);
                    skillMenuC4.SetActive(false);
                    skillMenuC5.SetActive(false);
                    skillMenuC6.SetActive(true);
                }
            }
        }
        else
        {
            skillMenuA.SetActive(false);
            skillMenuA2.SetActive(false);
            skillMenuA3.SetActive(false);
            skillMenuA4.SetActive(false);
            skillMenuA5.SetActive(false);
            skillMenuA6.SetActive(false);
            skillMenuA7.SetActive(false);
            skillMenuA8.SetActive(false);
            skillMenuB.SetActive(false);
            skillMenuB2.SetActive(false);
            skillMenuB3.SetActive(false);
            skillMenuB4.SetActive(false);
            skillMenuB5.SetActive(false);
            skillMenuB6.SetActive(false);
            skillMenuB7.SetActive(false);
            skillMenuB8.SetActive(false);
            skillMenuC.SetActive(false);
            skillMenuC2.SetActive(false);
            skillMenuC3.SetActive(false);
            skillMenuC4.SetActive(false);
            skillMenuC5.SetActive(false);
            skillMenuC6.SetActive(false);
            if (a == 0)
            {
                skillMenuBRU.SetActive(false);
                skillMenuB2RU.SetActive(false);
                skillMenuB3RU.SetActive(false);
                skillMenuB4RU.SetActive(false);
                skillMenuB5RU.SetActive(false);
                skillMenuB6RU.SetActive(false);
                skillMenuB7RU.SetActive(false);
                skillMenuB8RU.SetActive(false);
                skillMenuCRU.SetActive(false);
                skillMenuC2RU.SetActive(false);
                skillMenuC3RU.SetActive(false);
                skillMenuC4RU.SetActive(false);
                skillMenuC5RU.SetActive(false);
                skillMenuC6RU.SetActive(false);
                if (a2 == 0)
                {
                    skillMenuARU.SetActive(true);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(false);
                }
                else if (a2 == 1)
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(true);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(false);
                }
                else if (a2 == 2)
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(true);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(false);
                }
                else if (a2 == 3)
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(true);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(false);
                }
                else if (a2 == 4)
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(true);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(false);
                }
                else if (a2 == 5)
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(true);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(false);
                }
                else if (a2 == 6)
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(true);
                    skillMenuA8RU.SetActive(false);
                }
                else
                {
                    skillMenuARU.SetActive(false);
                    skillMenuA2RU.SetActive(false);
                    skillMenuA3RU.SetActive(false);
                    skillMenuA4RU.SetActive(false);
                    skillMenuA5RU.SetActive(false);
                    skillMenuA6RU.SetActive(false);
                    skillMenuA7RU.SetActive(false);
                    skillMenuA8RU.SetActive(true);
                }
            }
            else if (a == 1)
            {
                skillMenuARU.SetActive(false);
                skillMenuA2RU.SetActive(false);
                skillMenuA3RU.SetActive(false);
                skillMenuA4RU.SetActive(false);
                skillMenuA5RU.SetActive(false);
                skillMenuA6RU.SetActive(false);
                skillMenuA7RU.SetActive(false);
                skillMenuA8RU.SetActive(false);
                skillMenuCRU.SetActive(false);
                skillMenuC2RU.SetActive(false);
                skillMenuC3RU.SetActive(false);
                skillMenuC4RU.SetActive(false);
                skillMenuC5RU.SetActive(false);
                skillMenuC6RU.SetActive(false);
                if (a2 == 0)
                {
                    skillMenuBRU.SetActive(true);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(false);
                }
                else if (a2 == 1)
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(true);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(false);
                }
                else if (a2 == 2)
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(true);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(false);
                }
                else if (a2 == 3)
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(true);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(false);
                }
                else if (a2 == 4)
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(true);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(false);
                }
                else if (a2 == 5)
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(true);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(false);
                }
                else if (a2 == 6)
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(true);
                    skillMenuB8RU.SetActive(false);
                }
                else
                {
                    skillMenuBRU.SetActive(false);
                    skillMenuB2RU.SetActive(false);
                    skillMenuB3RU.SetActive(false);
                    skillMenuB4RU.SetActive(false);
                    skillMenuB5RU.SetActive(false);
                    skillMenuB6RU.SetActive(false);
                    skillMenuB7RU.SetActive(false);
                    skillMenuB8RU.SetActive(true);
                }
            }
            else
            {
                skillMenuBRU.SetActive(false);
                skillMenuB2RU.SetActive(false);
                skillMenuB3RU.SetActive(false);
                skillMenuB4RU.SetActive(false);
                skillMenuB5RU.SetActive(false);
                skillMenuB6RU.SetActive(false);
                skillMenuB7RU.SetActive(false);
                skillMenuB8RU.SetActive(false);
                skillMenuARU.SetActive(false);
                skillMenuA2RU.SetActive(false);
                skillMenuA3RU.SetActive(false);
                skillMenuA4RU.SetActive(false);
                skillMenuA5RU.SetActive(false);
                skillMenuA6RU.SetActive(false);
                skillMenuA7RU.SetActive(false);
                skillMenuA8RU.SetActive(false);
                if (a2 == 0)
                {
                    skillMenuCRU.SetActive(true);
                    skillMenuC2RU.SetActive(false);
                    skillMenuC3RU.SetActive(false);
                    skillMenuC4RU.SetActive(false);
                    skillMenuC5RU.SetActive(false);
                    skillMenuC6RU.SetActive(false);
                }
                else if (a2 == 1)
                {
                    skillMenuCRU.SetActive(false);
                    skillMenuC2RU.SetActive(true);
                    skillMenuC3RU.SetActive(false);
                    skillMenuC4RU.SetActive(false);
                    skillMenuC5RU.SetActive(false);
                    skillMenuC6RU.SetActive(false);
                }
                else if (a2 == 2)
                {
                    skillMenuCRU.SetActive(false);
                    skillMenuC2RU.SetActive(false);
                    skillMenuC3RU.SetActive(true);
                    skillMenuC4RU.SetActive(false);
                    skillMenuC5RU.SetActive(false);
                    skillMenuC6RU.SetActive(false);
                }
                else if (a2 == 3)
                {
                    skillMenuCRU.SetActive(false);
                    skillMenuC2RU.SetActive(false);
                    skillMenuC3RU.SetActive(false);
                    skillMenuC4RU.SetActive(true);
                    skillMenuC5RU.SetActive(false);
                    skillMenuC6RU.SetActive(false);
                }
                else if (a2 == 4)
                {
                    skillMenuCRU.SetActive(false);
                    skillMenuC2RU.SetActive(false);
                    skillMenuC3RU.SetActive(false);
                    skillMenuC4RU.SetActive(false);
                    skillMenuC5RU.SetActive(true);
                    skillMenuC6RU.SetActive(false);
                }
                else
                {
                    skillMenuCRU.SetActive(false);
                    skillMenuC2RU.SetActive(false);
                    skillMenuC3RU.SetActive(false);
                    skillMenuC4RU.SetActive(false);
                    skillMenuC5RU.SetActive(false);
                    skillMenuC6RU.SetActive(true);
                }
            }
        }
        if (a == 0)
        {
            a3.SetActive(true);
            a4.SetActive(false);
            a5.SetActive(false);
        }
        else if(a == 1)
        {
            a3.SetActive(false);
            a4.SetActive(true);
            a5.SetActive(false);
        }
        else
        {
            a3.SetActive(false);
            a4.SetActive(false);
            a5.SetActive(true);
        }
        if(a2 == 0)
        {
            a6.SetActive(true);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(false);
        }
        else if(a2 == 1)
        {
            a6.SetActive(false);
            a7.SetActive(true);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(false);
        }
        else if (a2 == 2)
        {
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(true);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(false);
        }
        else if (a2 == 3)
        {
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(true);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(false);
        }
        else if (a2 == 4)
        {
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(true);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(false);
        }
        else if (a2 == 5)
        {
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(true);
            a12.SetActive(false);
            a13.SetActive(false);
        }
        else if (a2 == 6)
        {
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(true);
            a13.SetActive(false);
        }
        else
        {
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(true);
        }
        if (a == 0)
        {
            b.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            b4.SetActive(true);
            b5.SetActive(true);
            b6.SetActive(true);
            b7.SetActive(true);
            b8.SetActive(true);
            c.SetActive(false);
            c2.SetActive(false);
            c3.SetActive(false);
            c4.SetActive(false);
            c5.SetActive(false);
            c6.SetActive(false);
            c7.SetActive(false);
            c8.SetActive(false);
            d.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(false);
            d5.SetActive(false);
            d6.SetActive(false);
        }
        else if(a == 1)
        {
            b.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
            b6.SetActive(false);
            b7.SetActive(false);
            b8.SetActive(false);
            c.SetActive(true);
            c2.SetActive(true);
            c3.SetActive(true);
            c4.SetActive(true);
            c5.SetActive(true);
            c6.SetActive(true);
            c7.SetActive(true);
            c8.SetActive(true);
            d.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(false);
            d5.SetActive(false);
            d6.SetActive(false);
        }
        else
        {
            b.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            b4.SetActive(false);
            b5.SetActive(false);
            b6.SetActive(false);
            b7.SetActive(false);
            b8.SetActive(false);
            c.SetActive(false);
            c2.SetActive(false);
            c3.SetActive(false);
            c4.SetActive(false);
            c5.SetActive(false);
            c6.SetActive(false);
            c7.SetActive(false);
            c8.SetActive(false);
            d.SetActive(true);
            d2.SetActive(true);
            d3.SetActive(true);
            d4.SetActive(true);
            d5.SetActive(true);
            d6.SetActive(true);
        }
        if(level == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if(level == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (level == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        if (level2 == 1)
        {
            star4.SetActive(true);
            star5.SetActive(false);
            star6.SetActive(false);
        }
        else if (level2 == 2)
        {
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(false);
        }
        else if (level2 == 3)
        {
            star4.SetActive(true);
            star5.SetActive(true);
            star6.SetActive(true);
        }
        else
        {
            star4.SetActive(false);
            star5.SetActive(false);
            star6.SetActive(false);
        }
        if (level3 == 1)
        {
            star7.SetActive(true);
            star8.SetActive(false);
            star9.SetActive(false);
        }
        else if (level3 == 2)
        {
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(false);
        }
        else if (level3 == 3)
        {
            star7.SetActive(true);
            star8.SetActive(true);
            star9.SetActive(true);
        }
        else
        {
            star7.SetActive(false);
            star8.SetActive(false);
            star9.SetActive(false);
        }
        if (level4 == 1)
        {
            star10.SetActive(true);
            star11.SetActive(false);
            star12.SetActive(false);
        }
        else if (level4 == 2)
        {
            star10.SetActive(true);
            star11.SetActive(true);
            star12.SetActive(false);
        }
        else if (level4 == 3)
        {
            star10.SetActive(true);
            star11.SetActive(true);
            star12.SetActive(true);
        }
        else
        {
            star10.SetActive(false);
            star11.SetActive(false);
            star12.SetActive(false);
        }
        if (level5 == 1)
        {
            star13.SetActive(true);
            star14.SetActive(false);
            star15.SetActive(false);
        }
        else if (level5 == 2)
        {
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(false);
        }
        else if (level5 == 3)
        {
            star13.SetActive(true);
            star14.SetActive(true);
            star15.SetActive(true);
        }
        else
        {
            star13.SetActive(false);
            star14.SetActive(false);
            star15.SetActive(false);
        }
        if (level6 == 1)
        {
            star16.SetActive(true);
            star17.SetActive(false);
            star18.SetActive(false);
        }
        else if (level6 == 2)
        {
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(false);
        }
        else if (level6 == 3)
        {
            star16.SetActive(true);
            star17.SetActive(true);
            star18.SetActive(true);
        }
        else
        {
            star16.SetActive(false);
            star17.SetActive(false);
            star18.SetActive(false);
        }
        if (level7 == 1)
        {
            star19.SetActive(true);
            star20.SetActive(false);
        }
        else if (level7 == 2)
        {
            star19.SetActive(true);
            star20.SetActive(true);
        }
        else
        {
            star19.SetActive(false);
            star20.SetActive(false);
        }
        if (level8 == 1)
        {
            star21.SetActive(true);
            star22.SetActive(false);
        }
        else if (level8 == 2)
        {
            star21.SetActive(true);
            star22.SetActive(true);
        }
        else
        {
            star21.SetActive(false);
            star22.SetActive(false);
        }
        if (levelB == 1)
        {
            starB1.SetActive(true);
            starB2.SetActive(false);
            starB3.SetActive(false);
        }
        else if (levelB == 2)
        {
            starB1.SetActive(true);
            starB2.SetActive(true);
            starB3.SetActive(false);
        }
        else if (levelB == 3)
        {
            starB1.SetActive(true);
            starB2.SetActive(true);
            starB3.SetActive(true);
        }
        else
        {
            starB1.SetActive(false);
            starB2.SetActive(false);
            starB3.SetActive(false);
        }
        if (levelB2 == 1)
        {
            starB4.SetActive(true);
            starB5.SetActive(false);
            starB6.SetActive(false);
        }
        else if (levelB2 == 2)
        {
            starB4.SetActive(true);
            starB5.SetActive(true);
            starB6.SetActive(false);
        }
        else if (levelB2 == 3)
        {
            starB4.SetActive(true);
            starB5.SetActive(true);
            starB6.SetActive(true);
        }
        else
        {
            starB4.SetActive(false);
            starB5.SetActive(false);
            starB6.SetActive(false);
        }
        if (levelB3 == 1)
        {
            starB7.SetActive(true);
            starB8.SetActive(false);
            starB9.SetActive(false);
        }
        else if (levelB3 == 2)
        {
            starB7.SetActive(true);
            starB8.SetActive(true);
            starB9.SetActive(false);
        }
        else if (levelB3 == 3)
        {
            starB7.SetActive(true);
            starB8.SetActive(true);
            starB9.SetActive(true);
        }
        else
        {
            starB7.SetActive(false);
            starB8.SetActive(false);
            starB9.SetActive(false);
        }
        if (levelB4 == 1)
        {
            starB10.SetActive(true);
            starB11.SetActive(false);
        }
        else if (levelB4 == 2)
        {
            starB10.SetActive(true);
            starB11.SetActive(true);
        }
        else
        {
            starB10.SetActive(false);
            starB11.SetActive(false);
        }
        if (levelB5 == 1)
        {
            starB12.SetActive(true);
            starB13.SetActive(false);
        }
        else if (levelB5 == 2)
        {
            starB12.SetActive(true);
            starB13.SetActive(true);
        }
        else
        {
            starB12.SetActive(false);
            starB13.SetActive(false);
        }
        if (levelB6 == 1)
        {
            starB14.SetActive(true);
            starB15.SetActive(false);
            starB16.SetActive(false);
        }
        else if (levelB6 == 2)
        {
            starB14.SetActive(true);
            starB15.SetActive(true);
            starB16.SetActive(false);
        }
        else if (levelB6 == 3)
        {
            starB14.SetActive(true);
            starB15.SetActive(true);
            starB16.SetActive(true);
        }
        else
        {
            starB14.SetActive(false);
            starB15.SetActive(false);
            starB16.SetActive(false);
        }
        if (levelB7 == 1)
        {
            starB17.SetActive(true);
            starB18.SetActive(false);
        }
        else if (levelB7 == 2)
        {
            starB17.SetActive(true);
            starB18.SetActive(true);
        }
        else
        {
            starB17.SetActive(false);
            starB18.SetActive(false);
        }
        if (levelB8 == 1)
        {
            starB19.SetActive(true);
            starB20.SetActive(false);
        }
        else if (levelB8 == 2)
        {
            starB19.SetActive(true);
            starB20.SetActive(true);
        }
        else
        {
            starB19.SetActive(false);
            starB20.SetActive(false);
        }
        if (levelC == 1)
        {
            starC1.SetActive(true);
            starC2.SetActive(false);
            starC3.SetActive(false);
        }
        else if (levelC == 2)
        {
            starC1.SetActive(true);
            starC2.SetActive(true);
            starC3.SetActive(false);
        }
        else if (levelC == 3)
        {
            starC1.SetActive(true);
            starC2.SetActive(true);
            starC3.SetActive(true);
        }
        else
        {
            starC1.SetActive(false);
            starC2.SetActive(false);
            starC3.SetActive(false);
        }
        if (levelC2 == 1)
        {
            starC4.SetActive(true);
            starC5.SetActive(false);
            starC6.SetActive(false);
        }
        else if (levelC2 == 2)
        {
            starC4.SetActive(true);
            starC5.SetActive(true);
            starC6.SetActive(false);
        }
        else if (levelC2 == 3)
        {
            starC4.SetActive(true);
            starC5.SetActive(true);
            starC6.SetActive(true);
        }
        else
        {
            starC4.SetActive(false);
            starC5.SetActive(false);
            starC6.SetActive(false);
        }
        if (levelC3 == 1)
        {
            starC7.SetActive(true);
            starC8.SetActive(false);
            starC9.SetActive(false);
        }
        else if (levelC3 == 2)
        {
            starC7.SetActive(true);
            starC8.SetActive(true);
            starC9.SetActive(false);
        }
        else if (levelC3 == 3)
        {
            starC7.SetActive(true);
            starC8.SetActive(true);
            starC9.SetActive(true);
        }
        else
        {
            starC7.SetActive(false);
            starC8.SetActive(false);
            starC9.SetActive(false);
        }
        if (levelC4 == 1)
        {
            starC10.SetActive(true);
            starC11.SetActive(false);
            starC12.SetActive(false);
        }
        else if (levelC4 == 2)
        {
            starC10.SetActive(true);
            starC11.SetActive(true);
            starC12.SetActive(false);
        }
        else if (levelC4 == 3)
        {
            starC10.SetActive(true);
            starC11.SetActive(true);
            starC12.SetActive(true);
        }
        else
        {
            starC10.SetActive(false);
            starC11.SetActive(false);
            starC12.SetActive(false);
        }
        if (levelC5 == 1)
        {
            starC13.SetActive(true);
            starC14.SetActive(false);
            starC15.SetActive(false);
        }
        else if (levelC5 == 2)
        {
            starC13.SetActive(true);
            starC14.SetActive(true);
            starC15.SetActive(false);
        }
        else if (levelC5 == 3)
        {
            starC13.SetActive(true);
            starC14.SetActive(true);
            starC15.SetActive(true);
        }
        else
        {
            starC13.SetActive(false);
            starC14.SetActive(false);
            starC15.SetActive(false);
        }
        if (levelC6 == 1)
        {
            starC16.SetActive(true);
            starC17.SetActive(false);
            starC18.SetActive(false);
        }
        else if (levelC6 == 2)
        {
            starC16.SetActive(true);
            starC17.SetActive(true);
            starC18.SetActive(false);
        }
        else if (levelC6 == 3)
        {
            starC16.SetActive(true);
            starC17.SetActive(true);
            starC18.SetActive(true);
        }
        else
        {
            starC16.SetActive(false);
            starC17.SetActive(false);
            starC18.SetActive(false);
        }
    }
    public void levelup()
    {
        if(skillPoints >= 1)
        {
            if(level < 3)
            {
                level += 1;
                skillPoints -= 1;
                if(training1.training2i == 5)
                {
                    training1.training3i5 += 1;
                }
            }
            
        }


    }
    public void levelup3()
    {
        if (skillPoints >= 1)
        {
            if (level3 < 3)
            {
                level3 += 1;
                skillPoints -= 1;
                if (training1.training2i == 5)
                {
                    training1.training3i5 += 1;
                }
            }

        }

    }
    public void levelup2()
    {
        if(Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (level2 < 3)
                {
                    level2 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }
        

    }
    public void levelup4()
    {
        if (Level1.PlayerLevel >= 15)
        {
            if (skillPoints >= 1)
            {
                if (level4 < 3)
                {
                    level4 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelup5()
    {
        if (Level1.PlayerLevel >= 20)
        {
            if (skillPoints >= 1)
            {
                if (level5 < 3)
                {
                    level5 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelup6()
    {
        if (Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (level6 < 3)
                {
                    level6 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelup7()
    {
        if (Level1.PlayerLevel >= 25)
        {
            if (skillPoints >= 1)
            {
                if (level7 < 2)
                {
                    level7 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelup8()
    {
        if (Level1.PlayerLevel >= 25)
        {
            if (skillPoints >= 1)
            {
                if (level8 < 2)
                {
                    level8 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupB()
    {
        if (skillPoints >= 1)
        {
            if (levelB < 3)
            {
                levelB += 1;
                skillPoints -= 1;
                if (training1.training2i == 5)
                {
                    training1.training3i5 += 1;
                }
            }

        }


    }
    public void levelupB2()
    {
        if (skillPoints >= 1)
        {
            if (levelB2 < 3)
            {
                levelB2 += 1;
                skillPoints -= 1;
                if (training1.training2i == 5)
                {
                    training1.training3i5 += 1;
                }
            }

        }


    }
    public void levelupB3()
    {
        if (Level1.PlayerLevel >= 5)
        {
            if (skillPoints >= 1)
            {
                if (levelB3 < 3)
                {
                    levelB3 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupB4()
    {
        if (Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (levelB4 < 2)
                {
                    levelB4 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupB5()
    {
        if (Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (levelB5 < 2)
                {
                    levelB5 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupB6()
    {
        if (Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (levelB6 < 3)
                {
                    levelB6 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupB7()
    {
        if (Level1.PlayerLevel >= 25)
        {
            if (skillPoints >= 1)
            {
                if (levelB7 < 2)
                {
                    levelB7 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupB8()
    {
        if (Level1.PlayerLevel >= 25)
        {
            if (skillPoints >= 1)
            {
                if (levelB8 < 2)
                {
                    levelB8 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupC()
    {
        if (skillPoints >= 1)
        {
            if (levelC < 3)
            {
                levelC += 1;
                skillPoints -= 1;
                if (training1.training2i == 5)
                {
                    training1.training3i5 += 1;
                }
            }

        }


    }
    public void levelupC2()
    {
        if (skillPoints >= 1)
        {
            if (levelC2 < 3)
            {
                levelC2 += 1;
                skillPoints -= 1;
                if (training1.training2i == 5)
                {
                    training1.training3i5 += 1;
                }
            }

        }


    }
    public void levelupC3()
    {
        if (Level1.PlayerLevel >= 7)
        {
            if (skillPoints >= 1)
            {
                if (levelC3 < 3)
                {
                    levelC3 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupC4()
    {
        if (Level1.PlayerLevel >= 7)
        {
            if (skillPoints >= 1)
            {
                if (levelC4 < 3)
                {
                    levelC4 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupC5()
    {
        if (Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (levelC5 < 3)
                {
                    levelC5 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void levelupC6()
    {
        if (Level1.PlayerLevel >= 10)
        {
            if (skillPoints >= 1)
            {
                if (levelC6 < 3)
                {
                    levelC6 += 1;
                    skillPoints -= 1;
                    if (training1.training2i == 5)
                    {
                        training1.training3i5 += 1;
                    }
                }

            }
        }


    }
    public void skillsOn()
    {
        a = 0;
        on = true;
        a2 = 0;
    }
    public void skillsOn2()
    {
        a = 1;
        on = false;
        a2 = 0;
    }
    public void skillsOn3()
    {
        a = 2;
        on = false;
        a2 = 0;
    }
    public void skillsOn4()
    {
        a2 = 0;
    }
    public void skillsOn5()
    {
        a2 = 1;
    }
    public void skillsOn6()
    {
        a2 = 2;
    }
    public void skillsOn7()
    {
        a2 = 3;
    }
    public void skillsOn8()
    {
        a2 = 4;
    }
    public void skillsOn9()
    {
        a2 = 5;
    }
    public void skillsOn10()
    {
        a2 = 6;
    }
    public void skillsOn11()
    {
        a2 = 7;
    }
}
