using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public trader trader1;
    public Skills skills;
    public float m;
    public float m2;
    public float m3;
    public float m4;
    public float m5;
    public float m6;
    // Start is called before the first frame update
    void Start()
    {
        trader1 = GameObject.FindGameObjectWithTag("Player").GetComponent<trader>();
        skills = GameObject.FindGameObjectWithTag("Player").GetComponent<Skills>();
        m2 = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if(skills.levelC5 == 1)
        {
            m6 = 1.25f;
        }
        else if(skills.levelC5 == 2)
        {
            m6 = 1.5f;
        }
        else if(skills.levelC5 == 3)
        {
            m6 = 1.75f;
        }
        else
        {
            m6 = 1f;
        }
        m4 = m2 * m3;
        m5 = m + m4;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            trader1.money += m5 * m6;
            Destroy(gameObject);
        }
    }
}
