using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerrySpawn : MonoBehaviour
{
    public float spawn;
    public float spawnStart;
    public GameObject spawnItem;
    public float n;
    public float n2;
    // Start is called before the first frame update
    void Start()
    {
        spawn = Random.Range(n, n2);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.childCount <= 0)
        {
            spawn -= Time.deltaTime;
        }
        if(spawn <= 0)
        {
            Instantiate(spawnItem, gameObject.transform);
            spawn = Random.Range(n, n2);
        }
    }
}
