using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tradermenu : MonoBehaviour
{
    public GameObject tmenu;
    public bool tmenuopen;
    public bool tmenuopen2;
    public GameObject skillbutton;
    // Start is called before the first frame update
    void Start()
    {
        tmenuopen2 = true;
        tmenuopen = false;
    }

    // Update is called once per frame
    void Update()
    {
        tmenu.SetActive(tmenuopen);
        skillbutton.SetActive(tmenuopen2);
    }
    public void TraderMenuOpen()
    {
        tmenuopen = true;
    }
    public void TraderMenuClose()
    {
        tmenuopen = false;
    }
    public void TraderMenuOpen2()
    {
        tmenuopen2 = false;
    }
    public void TraderMenuClose2()
    {
        tmenuopen2 = true;
    }
}
