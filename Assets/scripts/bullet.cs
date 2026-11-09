using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public float destroyTime;
    public PlayerController player;
    public LayerMask ground;
    private Vector2 target;
    private Transform w;
    // Start is called before the first frame update
    void Start()
    {
        w = GameObject.FindGameObjectWithTag("weapon").transform;
        Destroy(gameObject, destroyTime);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        target = new Vector2(w.position.x, w.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if(other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Ground2"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Ground3"))
        {
            Destroy(gameObject);
        }
    }
}
