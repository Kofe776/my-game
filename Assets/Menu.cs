using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public bool pause;
    public InventoryOpen IO;
    public Craft craft;
    public Pausemenu pausemenu;
    public tradermenu tradermenu1;
    public Ads ads1;
    public AdsMenu adsMenu1;
    public PlayerHP playerHP1;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        pause = false;
        IO = gameObject.GetComponent<InventoryOpen>();
        craft = gameObject.GetComponent<Craft>();
        pausemenu = gameObject.GetComponent<Pausemenu>();
        tradermenu1 = gameObject.GetComponent<tradermenu>();
        ads1 = gameObject.GetComponent<Ads>();
        adsMenu1 = gameObject.GetComponent<AdsMenu>();
        playerHP1 = gameObject.GetComponent<PlayerHP>();
        training1 = gameObject.GetComponent<training>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pause == false)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }
        if (IO.inventoryOn == true)
        {
            pause = true;
        }
        else if (pausemenu.pausemenuOn == true)
        {
            pause = true;
        }
        else if (tradermenu1.tmenuopen == true)
        {
            pause = true;
        }
        else if (ads1.a3 == true)
        {
            pause = true;
        }
        else if (adsMenu1.a3 == true)
        {
            pause = true;
        }
        else if (adsMenu1.a4 == true)
        {
            pause = true;
        }
        else if (playerHP1.a1 == true)
        {
            pause = true;
        }
        else if (training1.a1 == true)
        {
            pause = true;
        }
        else
        {
            pause = false;
        }
    }
    
}
