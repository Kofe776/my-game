using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject slotButton;
    public int Lenght;
    public int t;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PickUp3()
    {
        if(inventory.tradermenu2 == false)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = t;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
