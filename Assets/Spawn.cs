using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    public Inventory inventory;
    public float r;
    public float n;
    public float n2;
    public PlayerController Pcon;
    public bool islook;
    public float r2;
    public float y;
    public int i1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        Pcon = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        r = Random.Range(n, n2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnDroppedItem()
    {
        if(inventory.tradermenu2 == false)
        {
            if (Pcon.isLookingRight == true)
            {
                Vector3 playerPos = new Vector3(player.position.x + r, player.position.y, player.position.z);
                Instantiate(item, playerPos, Quaternion.identity);
            }
            else
            {
                Vector3 playerPos = new Vector3(player.position.x + -r, player.position.y, player.position.z);
                Instantiate(item, playerPos, Quaternion.identity);
            }
        }
    }
}
