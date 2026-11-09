using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGun : MonoBehaviour
{
    public Inventory inventory;
    public GameObject W;
    public float index4;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Equip()
    {
        if(inventory.tradermenu2 == false)
        {
            if (inventory.isFull2 == false)
            {
                inventory.isFull2 = true;
                Instantiate(W, inventory.slot.transform);
                Destroy(gameObject);
            }
        }
    }
}
