using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sell : MonoBehaviour
{
    public int sell2;
    public Inventory inventory;
    public trader tr;
    public GameObject sellmenu2;
    public SellMenu sellmenu;
    public Skills skills;
    public float s2;
    public float s3;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tr = GameObject.FindGameObjectWithTag("Player").GetComponent<trader>();
        sellmenu = GameObject.FindGameObjectWithTag("Player").GetComponent<SellMenu>();
        skills = GameObject.FindGameObjectWithTag("Player").GetComponent<Skills>();
    }

    // Update is called once per frame
    void Update()
    {
        if(skills.levelC4 == 1)
        {
            s2 = 1.1f;
        }
        else if(skills.levelC4 == 2)
        {
            s2 = 1.2f;
        }
        else if (skills.levelC4 == 3)
        {
            s2 = 1.3f;
        }
        else
        {
            s2 = 1f;
        }
        s3 = sell2 * s2;
    }
    public void sell3()
    {
        if(inventory.tradermenu2 == true)
        {
            sellmenu.on = true;
            gameObject.tag = "sell";
        }
        

    }
    public void sell4()
    {
        tr.money += s3;
        Destroy(gameObject);
    }
}
