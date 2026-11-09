using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft2 : MonoBehaviour
{
    public Inventory inventory;
    public Craft craft;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        craft = gameObject.GetComponent<Craft>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
