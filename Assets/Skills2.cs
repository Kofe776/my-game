using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills2 : MonoBehaviour
{
    public int s;
    public Skills skills;
    // Start is called before the first frame update
    void Start()
    {
        skills = GameObject.FindGameObjectWithTag("Player").GetComponent<Skills>();
    }

    // Update is called once per frame
    void Update()
    {
        s = skills.a;
        if(s == 0)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
