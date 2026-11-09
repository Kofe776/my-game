using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject spawnenemy1;
    public GameObject spawnenemy2;
    public GameObject spawnenemy7;
    public int spawnenemy3;
    public PlayerController playerController;
    public GameObject player2;
    public float spawndistance;
    public float d1;
    public float d2;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        spawnenemy3 = Random.Range(1, 4);
        player2 = GameObject.FindGameObjectWithTag("Player");
        spawndistance = Random.Range(-2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        d1 = gameObject.transform.position.y - player2.transform.position.y;
        d2 = Mathf.Abs(d1);
        if (Vector2.Distance(transform.position, player2.transform.position) > 20 && Vector2.Distance(transform.position, player2.transform.position) < 40 && d2 < 7)
        {
            if (playerController.EnemyCount < 6)
            {
                if (playerController.EnemySpawnTime <= 0)
                {
                    if (spawnenemy3 == 1)
                    {
                        Vector3 spawnenemy4 = new Vector3(gameObject.transform.position.x + spawndistance, gameObject.transform.position.y, gameObject.transform.position.z);
                        Instantiate(spawnenemy1, spawnenemy4, Quaternion.identity);
                        playerController.EnemyCount += 1;
                        playerController.EnemySpawnTime = Random.Range(10, 15);
                        spawndistance = Random.Range(-2f, 2f);
                        spawnenemy3 = Random.Range(1, 4);
                    }
                    else if(spawnenemy3 == 2)
                    {
                        Vector3 spawnenemy5 = new Vector3(gameObject.transform.position.x + spawndistance, gameObject.transform.position.y, gameObject.transform.position.z);
                        Instantiate(spawnenemy2, spawnenemy5, Quaternion.identity);
                        playerController.EnemyCount += 1;
                        playerController.EnemySpawnTime = Random.Range(10, 15);
                        spawndistance = Random.Range(-2f, 2f);
                        spawnenemy3 = Random.Range(1, 4);
                    }
                    else
                    {
                        Vector3 spawnenemy6 = new Vector3(gameObject.transform.position.x + spawndistance, gameObject.transform.position.y, gameObject.transform.position.z);
                        Instantiate(spawnenemy7, spawnenemy6, Quaternion.identity);
                        playerController.EnemyCount += 1;
                        playerController.EnemySpawnTime = Random.Range(10, 15);
                        spawndistance = Random.Range(-2f, 2f);
                        spawnenemy3 = Random.Range(1, 4);
                    }
                }
            }
        }
    }
}
