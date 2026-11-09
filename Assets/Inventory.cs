using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject slot;
    public bool isFull2;
    public float index2;
    public bool indexA;
    public Text text1;
    public Text text2;
    public string s;
    public PlayerController PCon;
    public float dropdistance;
    public GameObject W1;
    public GameObject I1;
    public GameObject I2;
    public int i3;
    public InventoryOpen inventoryOpen;
    public int[] b;
    public int Lenght;
    public GameObject I3;
    public GameObject I4;
    public GameObject I5;
    public GameObject I6;
    public GameObject I7;
    public trader trader1;
    public GameObject I8;
    public GameObject W2;
    public tradermenu tm;
    public bool tradermenu2;
    public GameObject W3;
    public GameObject I9;
    public GameObject I10;
    public GameObject W4;
    public GameObject I11;
    public GameObject W5;
    public GameObject I12;
    public GameObject W6;
    public GameObject I13;
    public GameObject W7;
    public GameObject I14;
    public GameObject W8;
    public GameObject I15;
    public GameObject I16;
    public GameObject I17;
    public GameObject I18;
    public GameObject I19;
    // Start is called before the first frame update
    void Start()
    {

        tm = gameObject.GetComponent<tradermenu>();
        trader1 = GameObject.FindGameObjectWithTag("Player").GetComponent<trader>();
        if (PlayerPrefs.HasKey("Index1") && PlayerPrefs.HasKey("Index2") && PlayerPrefs.HasKey("Index3") && PlayerPrefs.HasKey("Index4") && PlayerPrefs.HasKey("Index5") && PlayerPrefs.HasKey("Index6") && PlayerPrefs.HasKey("Index7") && PlayerPrefs.HasKey("Index8") && PlayerPrefs.HasKey("Index9") && PlayerPrefs.HasKey("Index10") && PlayerPrefs.HasKey("Index11") && PlayerPrefs.HasKey("Index12") && PlayerPrefs.HasKey("Index13") && PlayerPrefs.HasKey("Index14") && PlayerPrefs.HasKey("Index15") && PlayerPrefs.HasKey("Index16") && PlayerPrefs.HasKey("Index17") && PlayerPrefs.HasKey("Index18") && PlayerPrefs.HasKey("Index19") && PlayerPrefs.HasKey("Index20") && PlayerPrefs.HasKey("Index21") && PlayerPrefs.HasKey("Index22") && PlayerPrefs.HasKey("Index23") && PlayerPrefs.HasKey("Index24"))
        {
            b[0] = PlayerPrefs.GetInt("Index1");
            b[1] = PlayerPrefs.GetInt("Index2");
            b[2] = PlayerPrefs.GetInt("Index3");
            b[3] = PlayerPrefs.GetInt("Index4");
            b[4] = PlayerPrefs.GetInt("Index5");
            b[5] = PlayerPrefs.GetInt("Index6");
            b[6] = PlayerPrefs.GetInt("Index7");
            b[7] = PlayerPrefs.GetInt("Index8");
            b[8] = PlayerPrefs.GetInt("Index9");
            b[9] = PlayerPrefs.GetInt("Index10");
            b[10] = PlayerPrefs.GetInt("Index11");
            b[11] = PlayerPrefs.GetInt("Index12");
            b[12] = PlayerPrefs.GetInt("Index13");
            b[13] = PlayerPrefs.GetInt("Index14");
            b[14] = PlayerPrefs.GetInt("Index15");
            b[15] = PlayerPrefs.GetInt("Index16");
            b[16] = PlayerPrefs.GetInt("Index17");
            b[17] = PlayerPrefs.GetInt("Index18");
            b[18] = PlayerPrefs.GetInt("Index19");
            b[19] = PlayerPrefs.GetInt("Index20");
            b[20] = PlayerPrefs.GetInt("Index21");
            b[21] = PlayerPrefs.GetInt("Index22");
            b[22] = PlayerPrefs.GetInt("Index23");
            b[23] = PlayerPrefs.GetInt("Index24");
        }
        if (PlayerPrefs.HasKey("Index1"))
        {
            i3 = PlayerPrefs.GetInt("Index1");
        }
        else
        {

        }
        if(i3 == 1)
        {
            
        }
        
        if (PlayerPrefs.HasKey("Index"))
        {
            index2 = PlayerPrefs.GetFloat("Index");
        }
        else
        {

        }
        PCon = gameObject.GetComponent<PlayerController>();
        if(index2 == 10)
        {
            Equip();
        }
        if(index2 == 20)
        {
            Equip2();
        }
        if(index2 == 30)
        {
            Equip3();
        }
        if(index2 == 40)
        {
            Equip4();
        }
        if(index2 == 50)
        {
            Equip5();
        }
        if(index2 == 60)
        {
            Equip6();
        }
        if (index2 == 70)
        {
            Equip7();
        }
        if (index2 == 80)
        {
            Equip8();
        }
        for (int i = 0; i < Lenght; i++)
        {
            if (b[i] == 3)
            {
                Instantiate(I1, slots[i].transform);
                
            }
            if (b[i] == 4)
            {
                Instantiate(I2, slots[i].transform);
            }
            if (b[i] == 5)
            {
                Instantiate(I3, slots[i].transform);
            }
            if (b[i] == 6)
            {
                Instantiate(I4, slots[i].transform);
            }
            if (b[i] == 7)
            {
                Instantiate(I5, slots[i].transform);
            }
            if (b[i] == 8)
            {
                Instantiate(I6, slots[i].transform);
            }
            if (b[i] == 9)
            {
                Instantiate(I7, slots[i].transform);
            }
            if (b[i] == 10)
            {
                Instantiate(I8, slots[i].transform);
            }
            if (b[i] == 11)
            {
                Instantiate(I9, slots[i].transform);
            }
            if(b[i] == 12)
            {
                Instantiate(I10, slots[i].transform);
            }
            if(b[i] == 13)
            {
                Instantiate(I11, slots[i].transform);
            }
            if(b[i] == 14)
            {
                Instantiate(I12, slots[i].transform);
            }
            if (b[i] == 15)
            {
                Instantiate(I13, slots[i].transform);
            }
            if (b[i] == 16)
            {
                Instantiate(I14, slots[i].transform);
            }
            if (b[i] == 17)
            {
                Instantiate(I15, slots[i].transform);
            }
            if (b[i] == 18)
            {
                Instantiate(I16, slots[i].transform);
            }
            if (b[i] == 19)
            {
                Instantiate(I17, slots[i].transform);
            }
            if (b[i] == 20)
            {
                Instantiate(I18, slots[i].transform);
            }
            if (b[i] == 21)
            {
                Instantiate(I19, slots[i].transform);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetInt("Index1", b[0]);
        PlayerPrefs.SetInt("Index2", b[1]);
        PlayerPrefs.SetInt("Index3", b[2]);
        PlayerPrefs.SetInt("Index4", b[3]);
        PlayerPrefs.SetInt("Index5", b[4]);
        PlayerPrefs.SetInt("Index6", b[5]);
        PlayerPrefs.SetInt("Index7", b[6]);
        PlayerPrefs.SetInt("Index8", b[7]);
        PlayerPrefs.SetInt("Index9", b[8]);
        PlayerPrefs.SetInt("Index10", b[9]);
        PlayerPrefs.SetInt("Index11", b[10]);
        PlayerPrefs.SetInt("Index12", b[11]);
        PlayerPrefs.SetInt("Index13", b[12]);
        PlayerPrefs.SetInt("Index14", b[13]);
        PlayerPrefs.SetInt("Index15", b[14]);
        PlayerPrefs.SetInt("Index16", b[15]);
        PlayerPrefs.SetInt("Index17", b[16]);
        PlayerPrefs.SetInt("Index18", b[17]);
        PlayerPrefs.SetInt("Index19", b[18]);
        PlayerPrefs.SetInt("Index20", b[19]);
        PlayerPrefs.SetInt("Index21", b[20]);
        PlayerPrefs.SetInt("Index22", b[21]);
        PlayerPrefs.SetInt("Index23", b[22]);
        PlayerPrefs.SetInt("Index24", b[23]);
        PlayerPrefs.SetFloat("Index", index2);
        PlayerPrefs.Save();
        if (tm.tmenuopen2 == false)
        {
            tradermenu2 = true;
        }
        else
        {
            tradermenu2 = false;
        }
        i3 = slots[0].GetComponent<Slot>().i2;
        if (index2 == 0)
        {
            s = "20";
        }
        else if (index2 == 10)
        {
            s = "40";
        }
        text1.text = trader1.money.ToString();
        text2.text = PlayerHP.healt.ToString();
        if (index2 == 10)
        {
            PCon.gunon = true;
        }
        else if(index2 == 20)
        {
            PCon.gunon = true;
        }
        else if(index2 == 30)
        {
            PCon.gunon = true;
        }
        else if (index2 == 40)
        {
            PCon.gunon = true;
        }
        else if (index2 == 50)
        {
            PCon.gunon = true;
        }
        else if (index2 == 60)
        {
            PCon.gunon = true;
        }
        else if (index2 == 70)
        {
            PCon.gunon = true;
        }
        else if (index2 == 80)
        {
            PCon.gunon = true;
        }
        else
        {
            PCon.gunon = false;
        }

    }

    public void Equip()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W1, slot.transform);
        }
    }
    public void Equip2()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W2, slot.transform);
        }
    }
    public void Equip3()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W3, slot.transform);
        }
    }
    public void Equip4()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W4, slot.transform);
        }
    }
    public void Equip5()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W5, slot.transform);
        }
    }
    public void Equip6()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W6, slot.transform);
        }
    }
    public void Equip7()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W7, slot.transform);
        }
    }
    public void Equip8()
    {
        if (isFull2 == false)
        {
            isFull2 = true;
            indexA = true;
            Instantiate(W8, slot.transform);
        }
    }
}
