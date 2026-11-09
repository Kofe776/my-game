using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float y1;
    public GameObject bg;
    public float x1;
    // Start is called before the first frame update
    void Start()
    {
        bg = GameObject.FindGameObjectWithTag("Background");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cloudrPos = new Vector3(gameObject.transform.position.x, bg.transform.position.y + y1, gameObject.transform.position.z);
        gameObject.transform.position = cloudrPos;
    }
}
