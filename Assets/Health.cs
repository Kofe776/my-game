using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float healtup;
    public Inventory inventory;
    public int s;
    public float s2;
    public Skills skills;
    public PlayerHP playerHP;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        skills = GameObject.FindGameObjectWithTag("Player").GetComponent<Skills>();
        playerHP = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
    }

    // Update is called once per frame
    void Update()
    {
        if(s == 1)
        {
            if(skills.levelB2 == 1)
            {
                s2 = 1.2f;
            }
            else if(skills.levelB2 == 2)
            {
                s2 = 1.4f;
            }
            else if (skills.levelB2 == 3)
            {
                s2 = 1.6f;
            }
            else
            {
                s2 = 1f;
            }
        }
        else if(s == 2)
        {
            if (skills.levelB3 == 1)
            {
                s2 = 1.2f;
            }
            else if (skills.levelB3 == 2)
            {
                s2 = 1.4f;
            }
            else if (skills.levelB3 == 3)
            {
                s2 = 1.6f;
            }
            else
            {
                s2 = 1f;
            }
        }
        else
        {
            s2 = 1f;
        }
    }
    public void healt2()
    {
        if(inventory.tradermenu2 == false)
        {
            if(PlayerHP.healt != playerHP.maxhealt)
            {
                PlayerHP.healt += healtup * s2;
                Destroy(gameObject);
            }
        }
    }
}
