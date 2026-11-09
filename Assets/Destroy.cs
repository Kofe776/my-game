using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float destroytime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroytime -= Time.deltaTime;
        if(destroytime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
