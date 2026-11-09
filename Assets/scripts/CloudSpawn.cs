using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public float spawn;
    public float spawn2;
    public float a1;
    public float a2;
    public float b1;
    public float b2;
    public int d;
    // Start is called before the first frame update
    void Start()
    {
        spawn = Random.Range(a1, a2);
        spawn2 = Random.Range(b1, b2);
        d = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        spawn -= Time.deltaTime;
        if(spawn <= 0)
        {
            Vector3 e = new Vector3(gameObject.transform.position.x - 12, gameObject.transform.position.y + 5, gameObject.transform.position.z);
            if(d == 0)
            {
                Instantiate(c1, e, Quaternion.identity);
                spawn = Random.Range(a1, a2);
                spawn2 = Random.Range(b1, b2);
                d = Random.Range(0, 5);
            }
            if (d == 1)
            {
                Instantiate(c2, e, Quaternion.identity);
                spawn = Random.Range(a1, a2);
                spawn2 = Random.Range(b1, b2);
                d = Random.Range(0, 5);
            }
            if (d == 2)
            {
                Instantiate(c3, e, Quaternion.identity);
                spawn = Random.Range(a1, a2);
                spawn2 = Random.Range(b1, b2);
                d = Random.Range(0, 5);
            }
            if (d == 3)
            {
                Instantiate(c4, e, Quaternion.identity);
                spawn = Random.Range(a1, a2);
                spawn2 = Random.Range(b1, b2);
                d = Random.Range(0, 5);
            }
            if (d == 4)
            {
                Instantiate(c5, e, Quaternion.identity);
                spawn = Random.Range(a1, a2);
                spawn2 = Random.Range(b1, b2);
                d = Random.Range(0, 5);
            }
            if (d == 5)
            {
                Instantiate(c6, e, Quaternion.identity);
                spawn = Random.Range(a1, a2);
                spawn2 = Random.Range(b1, b2);
                d = Random.Range(0, 5);
            }
        }
    }
}
