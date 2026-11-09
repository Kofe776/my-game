using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftOpen : MonoBehaviour
{
    public GameObject CraftMenu;
    public bool craftOn;
    // Start is called before the first frame update
    void Start()
    {
        craftOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        CraftMenu.SetActive(craftOn);
    }
    public void CraftMenuOn()
    {
        craftOn = true;
    }
    public void CraftMenuOff()
    {
        craftOn = false;
    }
}
