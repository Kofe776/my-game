using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpen : MonoBehaviour
{
    public GameObject inventory;
    public bool inventoryOn;
    public CraftOpen craft;
    // Start is called before the first frame update
    void Start()
    {
        inventoryOn = false;
        craft = gameObject.GetComponent<CraftOpen>();
    }

    // Update is called once per frame
    void Update()
    {
        inventory.SetActive(inventoryOn);
    }
    public void InventoryOn()
    {
        inventoryOn = true;
    }
    public void InventoryOff()
    {
        inventoryOn = false;
    }

}
