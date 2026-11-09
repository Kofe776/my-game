using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Craft : MonoBehaviour
{
    public PlayerController playerController;
    public Level level1;
    public bool CraftObject;
    public int Lenght;
    public GameObject item;
    public Inventory inventory;
    public float Crafttime;
    public float StartCrafttime;
    public bool g;
    public Menu menu;
    public int craft1;
    public int craft2;
    public bool t;
    public bool t2;
    public int craft3;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;
    public int craft4;
    public int craft5;
    public int craft6;
    public bool t3;
    public bool t4;
    public int craft7;
    public int craft8;
    public int craft9;
    public bool t5;
    public bool t6;
    public int craft10;
    public int craft11;
    public int craft12;
    public bool t7;
    public bool t8;
    public int craft13;
    public int craft14;
    public int craft15;
    public bool t9;
    public bool t10;
    public int craft16;
    public int craft17;
    public int craft18;
    public bool t11;
    public bool t12;
    public int craft19;
    public int craft20;
    public int craft21;
    public int craft22;
    public int craft23;
    public bool t13;
    public bool t14;
    public int CMI;
    public GameObject CM;
    public GameObject CM2;
    public GameObject CM3;
    public GameObject CM4;
    public GameObject CM5;
    public GameObject CM6;
    public GameObject CM7;
    public GameObject CMRU;
    public GameObject CM2RU;
    public GameObject CM3RU;
    public GameObject CM4RU;
    public GameObject CM5RU;
    public GameObject CM6RU;
    public GameObject CM7RU;
    public GameObject CB;
    public GameObject CB2;
    public GameObject CB3;
    public GameObject CB4;
    public GameObject CB5;
    public GameObject CB6;
    public GameObject CB7;
    public GameObject CBRU;
    public GameObject CB2RU;
    public GameObject CB3RU;
    public GameObject CB4RU;
    public GameObject CB5RU;
    public GameObject CB6RU;
    public GameObject CB7RU;
    public GameObject CBOFF;
    public GameObject CB2OFF;
    public GameObject CB3OFF;
    public GameObject CB4OFF;
    public GameObject CB5OFF;
    public GameObject CBRUOFF;
    public GameObject CB2RUOFF;
    public GameObject CB3RUOFF;
    public GameObject CB4RUOFF;
    public GameObject CB5RUOFF;
    public float A1;
    public float[] A2;
    public float A3;
    public float[] A4;
    public float A5;
    public float[] A6;
    public float A7;
    public float[] A8;
    public float A9;
    public float[] A10;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text1RU;
    public Text text2RU;
    public Text text3RU;
    public Text text4RU;
    public Text text5RU;
    public Text text6RU;
    public Text text7RU;
    public Text text8RU;
    public GameObject CBb;
    public GameObject CB2b;
    public GameObject CB3b;
    public GameObject CB4b;
    public GameObject CB5b;
    public GameObject CB6b;
    public GameObject CB7b;
    public GameObject CBRUb;
    public GameObject CB2RUb;
    public GameObject CB3RUb;
    public GameObject CB4RUb;
    public GameObject CB5RUb;
    public GameObject CB6RUb;
    public GameObject CB7RUb;
    public float levelup1;
    public float levelup2;
    public float levelup3;
    public float levelup4;
    public float levelup5;
    public float levelup6;
    public Skills skills1;
    public float skills2;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        CraftObject = false;
        inventory = gameObject.GetComponent<Inventory>();
        playerController = gameObject.GetComponent<PlayerController>();
        level1 = gameObject.GetComponent<Level>();
        skills1 = gameObject.GetComponent<Skills>();
        Crafttime = StartCrafttime;
        menu = gameObject.GetComponent<Menu>();
        training1 = gameObject.GetComponent<training>();
        g = false;
        craft1 = 0;
        craft2 = 0;
        craft3 = 0;
        craft4 = 0;
        craft5 = 0;
        craft6 = 0;
        craft7 = 0;
        craft8 = 0;
        craft9 = 0;
        craft10 = 0;
        craft11 = 0;
        craft12 = 0;
        craft13 = 0;
        craft14 = 0;
        craft15 = 0;
        craft16 = 0;
        craft17 = 0;
        craft18 = 0;
        craft19 = 0;
        craft20 = 0;
        craft21 = 0;
        craft22 = 0;
        craft23 = 0;
        t = false;
        t2 = false;
        t3 = false;
        t4 = false;
        t5 = false;
        t6 = false;
        t7 = false;
        t8 = false;
        t9 = false;
        t10 = false;
        t11 = false;
        t12 = false;
        t13 = false;
        t14 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(skills1.levelC2 == 0)
        {
            skills2 = 1f;
        }
        else if(skills1.levelC2 == 1)
        {
            skills2 = 1.25f;
        }
        else if (skills1.levelC2 == 2)
        {
            skills2 = 1.5f;
        }
        else
        {
            skills2 = 1.75f;
        }
        levelup1 = 80 * skills2;
        levelup2 = 120 * skills2;
        levelup3 = 200 * skills2;
        levelup4 = 280 * skills2;
        levelup5 = 360 * skills2;
        levelup6 = 480 * skills2;
        text1.text = "4 (" + A1.ToString() + ")";
        text1RU.text = "4 (" + A1.ToString() + ")";
        text2.text = "1 (" + A7.ToString() + ")";
        text2RU.text = "1 (" + A7.ToString() + ")";
        text3.text = "2 (" + A9.ToString() + ")";
        text3RU.text = "2 (" + A9.ToString() + ")";
        text4.text = "6 (" + A1.ToString() + ")";
        text4RU.text = "6 (" + A1.ToString() + ")";
        text5.text = "5 (" + A3.ToString() + ")";
        text5RU.text = "5 (" + A3.ToString() + ")";
        text6.text = "7 (" + A3.ToString() + ")";
        text6RU.text = "7 (" + A3.ToString() + ")";
        text7.text = "6 (" + A5.ToString() + ")";
        text7RU.text = "6 (" + A5.ToString() + ")";
        text8.text = "8 (" + A5.ToString() + ")";
        text8RU.text = "8 (" + A5.ToString() + ")";
        if (A1 >= 4)
        {
            text1.color = Color.green;
            text1RU.color = Color.green;
        }
        else
        {
            text1.color = Color.red;
            text1RU.color = Color.red;
        }
        if (A7 >= 1)
        {
            text2.color = Color.green;
            text2RU.color = Color.green;
        }
        else
        {
            text2.color = Color.red;
            text2RU.color = Color.red;
        }
        if (A9 >= 2)
        {
            text3.color = Color.green;
            text3RU.color = Color.green;
        }
        else
        {
            text3.color = Color.red;
            text3RU.color = Color.red;
        }
        if (A1 >= 6)
        {
            text4.color = Color.green;
            text4RU.color = Color.green;
        }
        else
        {
            text4.color = Color.red;
            text4RU.color = Color.red;
        }
        if (A3 >= 5)
        {
            text5.color = Color.green;
            text5RU.color = Color.green;
        }
        else
        {
            text5.color = Color.red;
            text5RU.color = Color.red;
        }
        if (A3 >= 7)
        {
            text6.color = Color.green;
            text6RU.color = Color.green;
        }
        else
        {
            text6.color = Color.red;
            text6RU.color = Color.red;
        }
        if (A5 >= 6)
        {
            text7.color = Color.green;
            text7RU.color = Color.green;
        }
        else
        {
            text7.color = Color.red;
            text7RU.color = Color.red;
        }
        if (A5 >= 8)
        {
            text8.color = Color.green;
            text8RU.color = Color.green;
        }
        else
        {
            text8.color = Color.red;
            text8RU.color = Color.red;
        }
        A1 = A2[0] + A2[1] + A2[2] + A2[3] + A2[4] + A2[5] + A2[6] + A2[7] + A2[8] + A2[9] + A2[10] + A2[11] + A2[12] + A2[13] + A2[14] + A2[15] + A2[16] + A2[17] + A2[18] + A2[19] + A2[20] + A2[21] + A2[22] + A2[23];
        for (int i = 0; i < Lenght; i++)
        {
            if(inventory.b[i] == 18)
            {
                A2[i] = 1;
            }
            else
            {
                A2[i] = 0;
            }
        }
        A3 = A4[0] + A4[1] + A4[2] + A4[3] + A4[4] + A4[5] + A4[6] + A4[7] + A4[8] + A4[9] + A4[10] + A4[11] + A4[12] + A4[13] + A4[14] + A4[15] + A4[16] + A4[17] + A4[18] + A4[19] + A4[20] + A4[21] + A4[22] + A4[23];
        for (int i = 0; i < Lenght; i++)
        {
            if (inventory.b[i] == 19)
            {
                A4[i] = 1;
            }
            else
            {
                A4[i] = 0;
            }
        }
        A5 = A6[0] + A6[1] + A6[2] + A6[3] + A6[4] + A6[5] + A6[6] + A6[7] + A6[8] + A6[9] + A6[10] + A6[11] + A6[12] + A6[13] + A6[14] + A6[15] + A6[16] + A6[17] + A6[18] + A6[19] + A6[20] + A6[21] + A6[22] + A6[23];
        for (int i = 0; i < Lenght; i++)
        {
            if (inventory.b[i] == 20)
            {
                A6[i] = 1;
            }
            else
            {
                A6[i] = 0;
            }
        }
        A7 = A8[0] + A8[1] + A8[2] + A8[3] + A8[4] + A8[5] + A8[6] + A8[7] + A8[8] + A8[9] + A8[10] + A8[11] + A8[12] + A8[13] + A8[14] + A8[15] + A8[16] + A8[17] + A8[18] + A8[19] + A8[20] + A8[21] + A8[22] + A8[23];
        for (int i = 0; i < Lenght; i++)
        {
            if (inventory.b[i] == 8)
            {
                A8[i] = 1;
            }
            else
            {
                A8[i] = 0;
            }
        }
        A9 = A10[0] + A10[1] + A10[2] + A10[3] + A10[4] + A10[5] + A10[6] + A10[7] + A10[8] + A10[9] + A10[10] + A10[11] + A10[12] + A10[13] + A10[14] + A10[15] + A10[16] + A10[17] + A10[18] + A10[19] + A10[20] + A10[21] + A10[22] + A10[23];
        for (int i = 0; i < Lenght; i++)
        {
            if (inventory.b[i] == 17)
            {
                A10[i] = 1;
            }
            else
            {
                A10[i] = 0;
            }
        }
        if (level1.PlayerLevel >= 5)
        {
            
            CBOFF.SetActive(false);
            CBRUOFF.SetActive(false);
            if(A1 >= 6)
            {
                CB.SetActive(true);
                CBRU.SetActive(true);
                CBb.SetActive(false);
                CBRUb.SetActive(false);
            }
            else
            {
                CB.SetActive(false);
                CBRU.SetActive(false);
                CBb.SetActive(true);
                CBRUb.SetActive(true);
            }
        }
        else
        {
            CB.SetActive(false);
            CBRU.SetActive(false);
            CBb.SetActive(false);
            CBRUb.SetActive(false);
            CBOFF.SetActive(true);
            CBRUOFF.SetActive(true);
        }
        if (level1.PlayerLevel >= 10)
        {
            CB2OFF.SetActive(false);
            CB2RUOFF.SetActive(false);
            if (A3 >= 5)
            {
                CB2.SetActive(true);
                CB2RU.SetActive(true);
                CB2b.SetActive(false);
                CB2RUb.SetActive(false);
            }
            else
            {
                CB2.SetActive(false);
                CB2RU.SetActive(false);
                CB2b.SetActive(true);
                CB2RUb.SetActive(true);
            }
        }
        else
        {
            CB2.SetActive(false);
            CB2RU.SetActive(false);
            CB2b.SetActive(false);
            CB2RUb.SetActive(false);
            CB2OFF.SetActive(true);
            CB2RUOFF.SetActive(true);
        }
        if (level1.PlayerLevel >= 15)
        {
            CB3OFF.SetActive(false);
            CB3RUOFF.SetActive(false);
            if (A3 >= 7)
            {
                CB3.SetActive(true);
                CB3RU.SetActive(true);
                CB3b.SetActive(false);
                CB3RUb.SetActive(false);
            }
            else
            {
                CB3.SetActive(false);
                CB3RU.SetActive(false);
                CB3b.SetActive(true);
                CB3RUb.SetActive(true);
            }
        }
        else
        {
            CB3.SetActive(false);
            CB3RU.SetActive(false);
            CB3b.SetActive(false);
            CB3RUb.SetActive(false);
            CB3OFF.SetActive(true);
            CB3RUOFF.SetActive(true);
        }
        if (level1.PlayerLevel >= 15)
        {
            CB4OFF.SetActive(false);
            CB4RUOFF.SetActive(false);
            if (A5 >= 6)
            {
                CB4.SetActive(true);
                CB4RU.SetActive(true);
                CB4b.SetActive(false);
                CB4RUb.SetActive(false);
            }
            else
            {
                CB4.SetActive(false);
                CB4RU.SetActive(false);
                CB4b.SetActive(true);
                CB4RUb.SetActive(true);
            }
        }
        else
        {
            CB4.SetActive(false);
            CB4RU.SetActive(false);
            CB4b.SetActive(false);
            CB4RUb.SetActive(false);
            CB4OFF.SetActive(true);
            CB4RUOFF.SetActive(true);
        }
        if (level1.PlayerLevel >= 20)
        {
            CB5OFF.SetActive(false);
            CB5RUOFF.SetActive(false);
            if (A5 >= 8)
            {
                CB5.SetActive(true);
                CB5RU.SetActive(true);
                CB5b.SetActive(false);
                CB5RUb.SetActive(false);
            }
            else
            {
                CB5.SetActive(false);
                CB5RU.SetActive(false);
                CB5b.SetActive(true);
                CB5RUb.SetActive(true);
            }
        }
        else
        {
            CB5.SetActive(false);
            CB5RU.SetActive(false);
            CB5b.SetActive(false);
            CB5RUb.SetActive(false);
            CB5OFF.SetActive(true);
            CB5RUOFF.SetActive(true);
        }
        if (A1 >= 4)
        {
            CB6.SetActive(true);
            CB6RU.SetActive(true);
            CB6b.SetActive(false);
            CB6RUb.SetActive(false);
        }
        else
        {
            CB6.SetActive(false);
            CB6RU.SetActive(false);
            CB6b.SetActive(true);
            CB6RUb.SetActive(true);
        }
        if (A7 >= 1 && A9 >= 2)
        {
            CB7.SetActive(true);
            CB7RU.SetActive(true);
            CB7b.SetActive(false);
            CB7RUb.SetActive(false);
        }
        else
        {
            CB7.SetActive(false);
            CB7RU.SetActive(false);
            CB7b.SetActive(true);
            CB7RUb.SetActive(true);
        }
        if (playerController.language == 0)
        {
            CMRU.SetActive(false);
            CM2RU.SetActive(false);
            CM3RU.SetActive(false);
            CM4RU.SetActive(false);
            CM5RU.SetActive(false);
            CM6RU.SetActive(false);
            CM7RU.SetActive(false);
            if (CMI == 0)
            {
                CM.SetActive(true);
                CM2.SetActive(false);
                CM3.SetActive(false);
                CM4.SetActive(false);
                CM5.SetActive(false);
                CM6.SetActive(false);
                CM7.SetActive(false);
            }
            else if(CMI == 1)
            {
                CM.SetActive(false);
                CM2.SetActive(true);
                CM3.SetActive(false);
                CM4.SetActive(false);
                CM5.SetActive(false);
                CM6.SetActive(false);
                CM7.SetActive(false);
            }
            else if (CMI == 2)
            {
                CM.SetActive(false);
                CM2.SetActive(false);
                CM3.SetActive(true);
                CM4.SetActive(false);
                CM5.SetActive(false);
                CM6.SetActive(false);
                CM7.SetActive(false);
            }
            else if (CMI == 3)
            {
                CM.SetActive(false);
                CM2.SetActive(false);
                CM3.SetActive(false);
                CM4.SetActive(true);
                CM5.SetActive(false);
                CM6.SetActive(false);
                CM7.SetActive(false);
            }
            else if (CMI == 4)
            {
                CM.SetActive(false);
                CM2.SetActive(false);
                CM3.SetActive(false);
                CM4.SetActive(false);
                CM5.SetActive(true);
                CM6.SetActive(false);
                CM7.SetActive(false);
            }
            else if (CMI == 5)
            {
                CM.SetActive(false);
                CM2.SetActive(false);
                CM3.SetActive(false);
                CM4.SetActive(false);
                CM5.SetActive(false);
                CM6.SetActive(true);
                CM7.SetActive(false);
            }
            else
            {
                CM.SetActive(false);
                CM2.SetActive(false);
                CM3.SetActive(false);
                CM4.SetActive(false);
                CM5.SetActive(false);
                CM6.SetActive(false);
                CM7.SetActive(true);
            }
        }
        else
        {
            CM.SetActive(false);
            CM2.SetActive(false);
            CM3.SetActive(false);
            CM4.SetActive(false);
            CM5.SetActive(false);
            CM6.SetActive(false);
            CM7.SetActive(false);
            if (CMI == 0)
            {
                CMRU.SetActive(true);
                CM2RU.SetActive(false);
                CM3RU.SetActive(false);
                CM4RU.SetActive(false);
                CM5RU.SetActive(false);
                CM6RU.SetActive(false);
                CM7RU.SetActive(false);
            }
            else if (CMI == 1)
            {
                CMRU.SetActive(false);
                CM2RU.SetActive(true);
                CM3RU.SetActive(false);
                CM4RU.SetActive(false);
                CM5RU.SetActive(false);
                CM6RU.SetActive(false);
                CM7RU.SetActive(false);
            }
            else if (CMI == 2)
            {
                CMRU.SetActive(false);
                CM2RU.SetActive(false);
                CM3RU.SetActive(true);
                CM4RU.SetActive(false);
                CM5RU.SetActive(false);
                CM6RU.SetActive(false);
                CM7RU.SetActive(false);
            }
            else if (CMI == 3)
            {
                CMRU.SetActive(false);
                CM2RU.SetActive(false);
                CM3RU.SetActive(false);
                CM4RU.SetActive(true);
                CM5RU.SetActive(false);
                CM6RU.SetActive(false);
                CM7RU.SetActive(false);
            }
            else if (CMI == 4)
            {
                CMRU.SetActive(false);
                CM2RU.SetActive(false);
                CM3RU.SetActive(false);
                CM4RU.SetActive(false);
                CM5RU.SetActive(true);
                CM6RU.SetActive(false);
                CM7RU.SetActive(false);
            }
            else if (CMI == 5)
            {
                CMRU.SetActive(false);
                CM2RU.SetActive(false);
                CM3RU.SetActive(false);
                CM4RU.SetActive(false);
                CM5RU.SetActive(false);
                CM6RU.SetActive(true);
                CM7RU.SetActive(false);
            }
            else
            {
                CMRU.SetActive(false);
                CM2RU.SetActive(false);
                CM3RU.SetActive(false);
                CM4RU.SetActive(false);
                CM5RU.SetActive(false);
                CM6RU.SetActive(false);
                CM7RU.SetActive(true);
            }
        }
        if (craft2 == 24 && craft1 != 4)
        {
            craft2 = 0;
            craft1 = 0;
            craft3 = 0;

            t = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 100)
                {
                    inventory.b[i] = 18;

                }

            }

        }

        if (t2 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 4;
                    Instantiate(item, inventory.slots[i].transform);
                    craft1 = 0;
                    t2 = false;
                    craft2 = 0;
                    craft3 = 0;
                    level1.levelpoint2 += levelup1;
                    if(training1.training2i == 4)
                    {
                        training1.training3i4 += 1;
                    }
                    break;

                }
            }
        }

        if (t == true)
        {
            for (int i = 0; i < Lenght; i++)
            {
                

                if (inventory.b[i] == 100 && craft3 != 4)
                {
                    inventory.b[i] = 200;
                    craft3 += 1;

                    if (craft3 == 4)
                    {
                        t = false;
                        t2 = true;
                        break;
                    }

                }

            }
        }
        if (craft5 == 24 && craft4 != 6)
        {
            craft5 = 0;
            craft4 = 0;
            craft6 = 0;

            t3 = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 101)
                {
                    inventory.b[i] = 18;

                }

            }

        }
        if (t3 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {


                if (inventory.b[i] == 101 && craft6 != 6)
                {
                    inventory.b[i] = 200;
                    craft6 += 1;

                    if (craft6 == 6)
                    {
                        t3 = false;
                        t4 = true;
                        break;
                    }

                }

            }
        }
        if (t4 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 16;
                    Instantiate(item2, inventory.slots[i].transform);
                    craft4 = 0;
                    t4 = false;
                    craft5 = 0;
                    craft6 = 0;
                    level1.levelpoint2 += levelup2;
                    break;

                }
            }
        }
        if (craft8 == 24 && craft7 != 5)
        {
            craft7 = 0;
            craft8 = 0;
            craft9 = 0;

            t5 = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 102)
                {
                    inventory.b[i] = 19;

                }

            }

        }
        if (t5 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {


                if (inventory.b[i] == 102 && craft9 != 5)
                {
                    inventory.b[i] = 200;
                    craft9 += 1;

                    if (craft9 == 5)
                    {
                        t5 = false;
                        t6 = true;
                        break;
                    }

                }

            }
        }
        if (t6 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 13;
                    Instantiate(item3, inventory.slots[i].transform);
                    craft7 = 0;
                    t6 = false;
                    craft8 = 0;
                    craft9 = 0;
                    level1.levelpoint2 += levelup3;
                    break;

                }
            }
        }
        if (craft11 == 24 && craft10 != 7)
        {
            craft10 = 0;
            craft11 = 0;
            craft12 = 0;

            t7 = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 103)
                {
                    inventory.b[i] = 19;

                }

            }

        }
        if (t7 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {


                if (inventory.b[i] == 103 && craft12 != 7)
                {
                    inventory.b[i] = 200;
                    craft12 += 1;

                    if (craft12 == 7)
                    {
                        t7 = false;
                        t8 = true;
                        break;
                    }

                }

            }
        }
        if (t8 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 14;
                    Instantiate(item4, inventory.slots[i].transform);
                    craft10 = 0;
                    t8 = false;
                    craft11 = 0;
                    craft12 = 0;
                    level1.levelpoint2 += levelup4;
                    break;

                }
            }
        }
        if (craft14 == 24 && craft13 != 6)
        {
            craft13 = 0;
            craft14 = 0;
            craft15 = 0;

            t9 = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 104)
                {
                    inventory.b[i] = 20;

                }

            }

        }
        if (t9 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {


                if (inventory.b[i] == 104 && craft15 != 6)
                {
                    inventory.b[i] = 200;
                    craft15 += 1;

                    if (craft15 == 6)
                    {
                        t9 = false;
                        t10 = true;
                        break;
                    }

                }

            }
        }
        if (t10 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 12;
                    Instantiate(item5, inventory.slots[i].transform);
                    craft13 = 0;
                    t10 = false;
                    craft14 = 0;
                    craft15 = 0;
                    level1.levelpoint2 += levelup5;
                    break;

                }
            }
        }
        if (craft17 == 24 && craft16 != 8)
        {
            craft16 = 0;
            craft17 = 0;
            craft18 = 0;

            t11 = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 105)
                {
                    inventory.b[i] = 20;

                }

            }

        }
        if (t11 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {


                if (inventory.b[i] == 105 && craft18 != 8)
                {
                    inventory.b[i] = 200;
                    craft18 += 1;

                    if (craft18 == 8)
                    {
                        t11 = false;
                        t12 = true;
                        break;
                    }

                }

            }
        }
        if (t12 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 10;
                    Instantiate(item6, inventory.slots[i].transform);
                    craft16 = 0;
                    t12 = false;
                    craft17 = 0;
                    craft18 = 0;
                    level1.levelpoint2 += levelup6;
                    break;

                }
            }
        }
        if (craft21 == 24 && t13 == false)
        {
            craft19 = 0;
            craft20 = 0;
            craft21 = 0;
            craft22 = 0;
            craft23 = 0;
            t13 = false;
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 106)
                {
                    inventory.b[i] = 8;

                }
                if (inventory.b[i] == 107)
                {
                    inventory.b[i] = 17;

                }

            }

        }
        if (t13 == true && t14 == false)
        {
            for (int i = 0; i < Lenght; i++)
            {


                if (inventory.b[i] == 106 && craft22 != 1)
                {
                    inventory.b[i] = 200;
                    craft22 += 1;

                    if (craft22 == 1 && craft23 == 2)
                    {
                        t14 = true;
                        break;
                    }

                }
                if (inventory.b[i] == 107 && craft23 != 2)
                {
                    inventory.b[i] = 200;
                    craft23 += 1;

                    if (craft22 == 1 && craft23 == 2)
                    {
                        t14 = true;
                        break;
                    }

                }
            }
        }
        if (t14 == true)
        {
            for (int i = 0; i < Lenght; i++)
            {

                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = 9;
                    Instantiate(item7, inventory.slots[i].transform);
                    craft19 = 0;
                    craft20 = 0;
                    craft21 = 0;
                    craft22 = 0;
                    craft23 = 0;
                    t13 = false;
                    t14 = false;
                    break;

                }
            }
        }
    }
    public void CraftItem()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft2 += 1;
            
            if (inventory.b[i] == 18 && craft1 < 4)
            {
                inventory.b[i] = 100;
                craft1 += 1;
                
                if(craft1 == 4)
                {
                    t = true;
                    break;
                }
                
            }

        }

    }
    public void CraftItem2()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft5 += 1;

            if (inventory.b[i] == 18 && craft4 < 6)
            {
                inventory.b[i] = 101;
                craft4 += 1;

                if (craft4 == 6)
                {
                    t3 = true;
                    break;
                }

            }

        }

    }
    public void CraftItem3()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft8 += 1;

            if (inventory.b[i] == 19 && craft7 < 5)
            {
                inventory.b[i] = 102;
                craft7 += 1;

                if (craft7 == 5)
                {
                    t5 = true;
                    break;
                }

            }

        }

    }
    public void CraftItem4()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft11 += 1;

            if (inventory.b[i] == 19 && craft10 < 7)
            {
                inventory.b[i] = 103;
                craft10 += 1;

                if (craft10 == 7)
                {
                    t7 = true;
                    break;
                }

            }

        }

    }
    public void CraftItem5()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft14 += 1;

            if (inventory.b[i] == 20 && craft13 < 6)
            {
                inventory.b[i] = 104;
                craft13 += 1;

                if (craft13 == 6)
                {
                    t9 = true;
                    break;
                }

            }

        }

    }
    public void CraftItem6()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft17 += 1;

            if (inventory.b[i] == 20 && craft16 < 8)
            {
                inventory.b[i] = 105;
                craft16 += 1;

                if (craft16 == 8)
                {
                    t11 = true;
                    break;
                }

            }

        }

    }
    public void CraftItem7()
    {
        for (int i = 0; i < Lenght; i++)
        {
            craft21 += 1;

            if (inventory.b[i] == 8 && craft19 < 1)
            {
                inventory.b[i] = 106;
                craft19 += 1;

                if (craft19 == 1 && craft20 == 2)
                {
                    t13 = true;
                    break;
                }

            }
            if (inventory.b[i] == 17 && craft20 < 2)
            {
                inventory.b[i] = 107;
                craft20 += 1;

                if (craft19 == 1 && craft20 == 2)
                {
                    t13 = true;
                    break;
                }

            }

        }

    }
    public void cmON1()
    {
        CMI = 0;
    }
    public void cmON2()
    {
        CMI = 1;
    }
    public void cmON3()
    {
        CMI = 2;
    }
    public void cmON4()
    {
        CMI = 3;
    }
    public void cmON5()
    {
        CMI = 4;
    }
    public void cmON6()
    {
        CMI = 5;
    }
    public void cmON7()
    {
        CMI = 6;
    }
}
