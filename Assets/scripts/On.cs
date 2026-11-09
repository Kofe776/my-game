using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On : MonoBehaviour
{
    public GameObject gunbutton;
    public bool onoff;
    public Inventory inventory2;
    // Start is called before the first frame update
    void Start()
    {
        onoff = true;
        inventory2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory2.index2 >= 10)
        {
            if (onoff == true)
            {
                onoff = false;
            }
        }
        if (inventory2.index2 <= 9)
        {
            if (onoff == false)
            {
                onoff = true;
            }
        }
        gunbutton.SetActive(onoff);
    }
}
