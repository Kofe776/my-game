using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2 : MonoBehaviour
{
    public float destroyTime;
    public float StartDestroyTime;
    // Start is called before the first frame update
    void Start()
    {
        destroyTime = StartDestroyTime;
    }

    // Update is called once per frame
    void Update()
    {
        destroyTime -= Time.deltaTime;
        if(destroyTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
