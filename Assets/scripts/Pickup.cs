using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Inventory inventory;
    public GameObject slotButton;
    public int Lenght;
    public GameObject player;
    public int index1;
    public int t;
    public int trainingitem;
    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.transform.position) < 2)
        {
            gameObject.tag = "Item";
        }
        else
        {
            gameObject.tag = "Item2";
        }
        
    }
    public void pickup()
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
