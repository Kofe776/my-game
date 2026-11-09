using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryIndex : MonoBehaviour
{
    public Inventory inventory;
    public float index5;
    public int Lenght;
    public int i1;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InventoryI()
    {
        if(inventory.tradermenu2 == false)
        {
            if (inventory.indexA == false)
            {
                inventory.index2 += i1;
                inventory.indexA = true;
            }
        }

    }
    public void InventoryI2()
    {
        if(inventory.tradermenu2 == false)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (inventory.b[i] == 2)
                {
                    inventory.index2 -= i1;
                    inventory.indexA = false;
                    break;
                }
            }
        }

    }
}
