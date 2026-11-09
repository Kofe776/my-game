using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target;
    public float destroyTime;
    public float damage;
    public Skills skills;
    public PlayerHP playerhp;
    public float s;
    public float s2;
    public float s3;
    public float critical;
    public PlayerController player2;
    public float texthpF;
    public float damage2;
    public float a1;
    public float a2;
    public float a3;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        skills = GameObject.FindGameObjectWithTag("Player").GetComponent<Skills>();
        player2 = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
        critical = Random.Range(0f, 1f);
        a2 = transform.position.y - player.transform.position.y;
        a3 = transform.position.x - player.transform.position.x;
        a1 = a2 / a3 * 45;
        if (skills.levelB == 1)
        {
            s = 0.9f;
        }
        else if (skills.levelB == 2)
        {
            s = 0.8f;
        }
        else if (skills.levelB == 3)
        {
            s = 0.7f;
        }
        else
        {
            s = 1f;
        }
        if (skills.levelB4 == 1)
        {
            s2 = 0.9f;
        }
        else if (skills.levelB4 == 2)
        {
            s2 = 0.8f;
        }
        else
        {
            s2 = 2f;
        }
        if (PlayerHP.healt < playerhp.maxhealt / 2)
        {
            if (skills.levelB7 == 1)
            {
                s3 = 0.8f;
            }
            else if (skills.levelB7 == 2)
            {
                s3 = 0.6f;
            }
            else
            {
                s3 = 1f;
            }
        }
        else
        {
            s3 = 1f;
        }
        damage2 = (damage * s);
        texthpF = (int)(damage2 * s3);
    }

    // Update is called once per frame
    void Update()
    {
        damage2 = (damage * s);
        texthpF = (int)(damage2 * s3);

        if (skills.levelB == 1)
        {
            s = 0.9f;
        }
        else if (skills.levelB == 2)
        {
            s = 0.8f;
        }
        else if (skills.levelB == 3)
        {
            s = 0.7f;
        }
        else
        {
            s = 1f;
        }
        if (skills.levelB4 == 1)
        {
            s2 = 0.9f;
        }
        else if (skills.levelB4 == 2)
        {
            s2 = 0.8f;
        }
        else
        {
            s2 = 2f;
        }
        if(PlayerHP.healt < playerhp.maxhealt / 2)
        {
            if (skills.levelB7 == 1)
            {
                s3 = 0.8f;
            }
            else if (skills.levelB7 == 2)
            {
                s3 = 0.6f;
            }
            else
            {
                s3 = 1f;
            }
        }
        else
        {
            s3 = 1f;
        }
        destroyTime -= Time.deltaTime;
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {

        }
        if(destroyTime <= 0)
        {
            Destroy(gameObject);
        }
        

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(critical > s2)
            {
                PlayerHP.healt -= damage2 * s3 * 0;
                player2.textHP.text = "-0";
                player2.textHPtime = player2.textHPtimeStart;
            }
            else
            {
                PlayerHP.healt -= (int)(damage2 * s3);
                player2.textHP.text = "-" + texthpF.ToString();
                player2.textHPtime = player2.textHPtimeStart;
            }
            player2.regainTime = player2.regainStartTime;
            DestroyProjectile();
        }
        if(other.CompareTag("Ground"))
        {
            DestroyProjectile();
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
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
