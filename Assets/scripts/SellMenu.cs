using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellMenu : MonoBehaviour
{
    public bool on;
    public float sellmenu2;
    public GameObject sellobject;
    public sell s;
    public GameObject sellmenu3;
    public Text text1;
    public PlayerController playerController;
    public Text text2;
    public Text text3;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
        playerController = gameObject.GetComponent<PlayerController>();
        training1 = gameObject.GetComponent<training>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.language == 0)
        {
            text3.text = "Cancel";
            text2.text = "Sell";
        }
        else
        {
            text3.text = "Отменить";
            text2.text = "Продать";
        }
        sellmenu3.SetActive(on);
        sellobject = GameObject.FindGameObjectWithTag("sell");
        if(sellobject != null)
        {
            s = sellobject.GetComponent<sell>();
            text1.text = s.s3.ToString();
        }
    }
    public void sell5()
    {
        s.sell4();
        on = false;
        if(training1.training2i == 3)
        {
            training1.training3i3 += 1;
        }
    }
    public void cancel()
    {
        
        on = false;
        if(sellobject != null)
        {
            sellobject.tag = "InventoryItem";
        }
    }
}
