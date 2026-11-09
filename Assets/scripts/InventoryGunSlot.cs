using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGunSlot : MonoBehaviour
{
    public Inventory inventory;
    public float index3;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull2 = false;
        }

    }
    public void DropItem2()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Pickup2>().PickUp3();
            GameObject.Destroy(child.gameObject);
        }
    }
}
