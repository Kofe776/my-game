using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    public int i2;
    public int b;
    public Spawn spawn;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {

        if(transform.childCount <= 0 && inventory.b[i] != 200)
        {
            inventory.b[i] = 2;

        }
        foreach (Transform child in transform)
        {
            i2 = child.GetComponent<Spawn>().i1;

        }

        foreach (Transform child in transform)
        {
            if (inventory.b[i] == 200)
            {
                GameObject.Destroy(child.gameObject);
                inventory.b[i] = 2;
            }

        }
    }
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }

}
