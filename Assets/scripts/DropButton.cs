using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropButton : MonoBehaviour
{
    public tradermenu tm;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject b10;
    public GameObject b11;
    public GameObject b12;
    public GameObject b13;
    public GameObject b14;
    public GameObject b15;
    public GameObject b16;
    public GameObject b17;
    public GameObject b18;
    public GameObject b19;
    public GameObject b20;
    public GameObject b21;
    public GameObject b22;
    public GameObject b23;
    public GameObject b24;
    // Start is called before the first frame update
    void Start()
    {
        tm = gameObject.GetComponent<tradermenu>();
    }

    // Update is called once per frame
    void Update()
    {
        b1.SetActive(tm.tmenuopen2);
        b2.SetActive(tm.tmenuopen2);
        b3.SetActive(tm.tmenuopen2);
        b4.SetActive(tm.tmenuopen2);
        b5.SetActive(tm.tmenuopen2);
        b6.SetActive(tm.tmenuopen2);
        b7.SetActive(tm.tmenuopen2);
        b8.SetActive(tm.tmenuopen2);
        b9.SetActive(tm.tmenuopen2);
        b10.SetActive(tm.tmenuopen2);
        b11.SetActive(tm.tmenuopen2);
        b12.SetActive(tm.tmenuopen2);
        b13.SetActive(tm.tmenuopen2);
        b14.SetActive(tm.tmenuopen2);
        b15.SetActive(tm.tmenuopen2);
        b16.SetActive(tm.tmenuopen2);
        b17.SetActive(tm.tmenuopen2);
        b18.SetActive(tm.tmenuopen2);
        b19.SetActive(tm.tmenuopen2);
        b20.SetActive(tm.tmenuopen2);
        b21.SetActive(tm.tmenuopen2);
        b22.SetActive(tm.tmenuopen2);
        b23.SetActive(tm.tmenuopen2);
        b24.SetActive(tm.tmenuopen2);
    }
}
