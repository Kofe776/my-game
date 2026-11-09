using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour
{
    public bool pausemenuOn;
    public GameObject exitbutton;
    public GameObject exitbutton2;
    public GameObject off1;
    public GameObject off2;
    public GameObject off3;
    public GameObject off4;
    public GameObject off5;
    public GameObject off6;
    public GameObject off7;
    public GameObject off8;
    public GameObject off9;
    public GameObject off10;
    public GameObject off11;
    public GameObject off13;
    public bool off;
    public PlayerController playerController;
    public Text text1;
    public Text text2;
    public PlayerHP playerHP1;
    public GameObject offbutton1;
    public bool offbutton2;
    // Start is called before the first frame update
    void Start()
    {
        pausemenuOn = false;
        playerController = gameObject.GetComponent<PlayerController>();
        playerHP1 = gameObject.GetComponent<PlayerHP>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.language == 0)
        {
            
            text1.text = "Resume";
            text2.text = "Main menu";
        }
        else
        {
            
            text1.text = "Продолжить";
            text2.text = "Главное меню";
        }
        exitbutton.SetActive(pausemenuOn);
        exitbutton2.SetActive(pausemenuOn);
        if (pausemenuOn == true)
        {
            off = false;
        }
        else if (playerHP1.a1 == true)
        {
            off = false;
        }
        else
        {
            off = true;
        }
        off1.SetActive(off);
        off2.SetActive(off);
        off3.SetActive(off);
        off4.SetActive(off);
        off5.SetActive(off);
        off6.SetActive(off);
        off7.SetActive(off);
        off8.SetActive(off);
        off9.SetActive(off);
        off10.SetActive(off);
        off11.SetActive(off);
        off13.SetActive(off);
        if(playerHP1.a1 == true)
        {
            offbutton2 = false;
        }
        else
        {
            offbutton2 = true;
        }
        offbutton1.SetActive(offbutton2);
    }
    public void pausemenuon()
    {
        if(pausemenuOn == true)
        {
            pausemenuOn = false;
        }
        else
        {
            pausemenuOn = true;
        }
    }
}
