using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy2 : MonoBehaviour
{
    public bool isJump;
    public LayerMask jump;
    public Transform jumpCheck;
    public bool isJump2;
    public Transform jumpCheck2;
    public Transform jumpCheck3;
    public bool isJump3;
    public float speed;
    public float stoppingdistance;
    public float retreatdistance;
    public GameObject player;
    public float timeBtwShots;
    public float startTimeBtwShots;
    public SpriteRenderer sr;
    public float jumpForse;
    public Rigidbody2D rb;
    public float jumpDistance;
    public float shotDistance;
    public float rundistance;
    public float maxHP;
    public float HP;
    public float ShotDistance2;
    public float Damage;
    public float timeBtwShots2;
    public float startTimeBtwShots2;
    public GameObject drop;
    public GameObject drop2;
    public float indexB;
    public Inventory inventory;
    public PlayerController player2;
    public bool isGrounded2;
    public float isGroundedfloat;
    public float startisGroundedfloat;
    public Menu menu;
    public trader trader1;
    public bool a1;
    public bool a2;
    public Animator anim;
    public float Damage2;
    public float Damage3;
    public float Damage4;
    public float Damage5;
    public int a;
    public float Damage6;
    public Text text1;
    public float t;
    public float tStart;
    public Skills skills;
    public float s;
    public float s2;
    public float s3;
    public float s4;
    public float s5;
    public float critical;
    public float Damagetext;
    public float Damagetext2;
    public float Damagetext3;
    public float Damagetext4;
    public float Damagetext5;
    public float Damagetext6;
    public float Damagetext7;
    public float Damagetext8;
    public float s6;
    public float s7;
    public float critical2;
    public PlayerHP playerhp;
    public float s8;
    public float s9;
    public float critical3;
    public float s10;
    public float drop4;
    public float dropSpawnDistance;
    public float drop5;
    public float drop6;
    public Level level;
    public float levelS;
    public float levelS2;
    public float levelS3;
    public float critical4;
    public float s11;
    public float texthpF;
    public float d1;
    public float d2;
    public float d3;
    public float d4;
    public AudioSource audio1;
    public bool audio2;
    public float audio3;
    public float audio4;
    public AdsMenu adsMenu1;
    public float adsmenu2;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        timeBtwShots = startTimeBtwShots;
        timeBtwShots2 = startTimeBtwShots2;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        player2 = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        isGroundedfloat = startisGroundedfloat;
        menu = GameObject.FindGameObjectWithTag("Player").GetComponent<Menu>();
        trader1 = GameObject.FindGameObjectWithTag("Player").GetComponent<trader>();
        skills = GameObject.FindGameObjectWithTag("Player").GetComponent<Skills>();
        critical = Random.Range(0f, 1f);
        critical2 = Random.Range(0f, 1f);
        playerhp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
        critical3 = Random.Range(0f, 1f);
        drop4 = Random.Range(0f, 1f);
        drop6 = Random.Range(-0.5f, 0.5f);
        level = GameObject.FindGameObjectWithTag("Player").GetComponent<Level>();
        critical4 = Random.Range(0f, 1f);
        adsMenu1 = GameObject.FindGameObjectWithTag("Player").GetComponent<AdsMenu>();
        training1 = GameObject.FindGameObjectWithTag("Player").GetComponent<training>();
    }

    // Update is called once per frame
    void Update()
    {
        if (adsMenu1.menuads4 == true)
        {
            adsmenu2 = 2;
        }
        else
        {
            adsmenu2 = 1;
        }
        levelS3 = levelS * levelS2 * adsmenu2;
        if (Vector2.Distance(transform.position, player.transform.position) > 65)
        {
            player2.EnemyCount -= 1;
            Destroy(gameObject);
        }
        d1 = gameObject.transform.position.x - player.transform.position.x;
        d2 = Mathf.Abs(d1);
        d3 = gameObject.transform.position.y - player.transform.position.y;
        d4 = Mathf.Abs(d3);
        texthpF = (int)(Damage6 * s8 * s10);
        if (skills.levelC6 == 1)
        {
            s11 = 0.8f;
        }
        else if (skills.levelC6 == 2)
        {
            s11 = 0.6f;
        }
        else if (skills.levelC6 == 3)
        {
            s11 = 0.4f;
        }
        else
        {
            s11 = 2f;
        }
        if (skills.levelC == 1)
        {
            levelS2 = 1.25f;
        }
        else if (skills.levelC == 2)
        {
            levelS2 = 1.5f;
        }
        else if (skills.levelC == 3)
        {
            levelS2 = 1.75f;
        }
        else
        {
            levelS2 = 1f;
        }
        if (skills.levelB == 1)
        {
            s8 = 0.9f;
        }
        else if(skills.levelB == 2)
        {
            s8 = 0.8f;
        }
        else if (skills.levelB == 3)
        {
            s8 = 0.7f;
        }
        else
        {
            s8 = 1f;
        }
        if(skills.levelB4 == 1)
        {
            s9 = 0.9f;
        }
        else if(skills.levelB4 == 2)
        {
            s9 = 0.8f;
        }
        else
        {
            s9 = 2f;
        }
        if (PlayerHP.healt < playerhp.maxhealt / 2)
        {
            if (skills.level7 == 1)
            {
                s6 = 1.25f;
            }
            else if (skills.level7 == 2)
            {
                s6 = 1.5f;
            }
            else
            {
                s6 = 1f;
            }
            if (skills.levelB7 == 1)
            {
                s10 = 0.8f;
            }
            else if (skills.levelB7 == 2)
            {
                s10 = 0.6f;
            }
            else
            {
                s10 = 1f;
            }
        }
        else
        {
            s6 = 1f;
            s10 = 1f;
        }
        if (skills.level8 == 1)
        {
            s7 = 0.9f;

        }
        else if (skills.level8 == 2)
        {
            s7 = 0.8f;

        }
        else
        {
            s7 = 2f;

        }

        if (skills.level == 1)
        {
            s = 1.1f;

        }
        else if (skills.level == 2)
        {
            s = 1.2f;

        }
        else if (skills.level == 3)
        {
            s = 1.3f;

        }
        else
        {
            s = 1;
        }
        if (skills.level2 == 1)
        {
            s2 = 1.1f;

        }
        else if (skills.level2 == 2)
        {
            s2 = 1.2f;

        }
        else if (skills.level2 == 3)
        {
            s2 = 1.3f;

        }
        else
        {
            s2 = 1;
        }
        if (skills.level3 == 1)
        {
            s3 = 1.1f;

        }
        else if (skills.level3 == 2)
        {
            s3 = 1.2f;

        }
        else if (skills.level3 == 3)
        {
            s3 = 1.3f;

        }
        else
        {
            s3 = 1;
        }
        if (skills.level4 == 1)
        {
            s4 = 1.1f;

        }
        else if (skills.level4 == 2)
        {
            s4 = 1.2f;

        }
        else if (skills.level4 == 3)
        {
            s4 = 1.3f;

        }
        else
        {
            s4 = 1;
        }
        if (skills.level5 == 1)
        {
            s5 = 1.1f;

        }
        else if (skills.level5 == 2)
        {
            s5 = 1.2f;

        }
        else if (skills.level5 == 3)
        {
            s5 = 1.3f;

        }
        else
        {
            s5 = 1;
        }

        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext = (int)(Damage * s3 * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext = (int)(Damage * s3 * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext = (int)(Damage * s3 * 2 * s6);
        }
        else
        {
            Damagetext = (int)(Damage * s3 * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext2 = (int)(Damage * s * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext2 = (int)(Damage * s * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext2 = (int)(Damage * s * 2 * s6);
        }
        else
        {
            Damagetext2 = (int)(Damage * s * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext3 = (int)(Damage2 * s4 * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext3 = (int)(Damage2 * s4 * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext3 = (int)(Damage2 * s4 * 2 * s6);
        }
        else
        {
            Damagetext3 = (int)(Damage2 * s4 * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext4 = (int)(Damage3 * s4 * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext4 = (int)(Damage3 * s4 * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext4 = (int)(Damage3 * s4 * 2 * s6);
        }
        else
        {
            Damagetext4 = (int)(Damage3 * s4 * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext5 = (int)(Damage4 * s2 * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext5 = (int)(Damage4 * s2 * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext5 = (int)(Damage4 * s2 * 2 * s6);
        }
        else
        {
            Damagetext5 = (int)(Damage4 * s2 * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext6 = (int)(Damage5 * s5 * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext6 = (int)(Damage5 * s5 * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext6 = (int)(Damage5 * s5 * 2 * s6);
        }
        else
        {
            Damagetext6 = (int)(Damage5 * s5 * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext7 = (int)(Damage2 * s * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext7 = (int)(Damage2 * s * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext7 = (int)(Damage2 * s * 2 * s6);
        }
        else
        {
            Damagetext7 = (int)(Damage2 * s * s6);
        }
        if (skills.level6 == 1 && critical > 0.9f)
        {
            Damagetext8 = (int)(Damage * s2 * 2 * s6);
        }
        else if (skills.level6 == 2 && critical > 0.8f)
        {
            Damagetext8 = (int)(Damage * s2 * 2 * s6);
        }
        else if (skills.level6 == 3 && critical > 0.7f)
        {
            Damagetext8 = (int)(Damage * s2 * 2 * s6);
        }
        else
        {
            Damagetext8 = (int)(Damage * s2 * s6);
        }

        if (a1 == true)
        {
            if (a == 0)
            {
                anim.SetBool("run", true);

            }
            else if (a == 1)
            {
                anim.SetBool("run2", true);
            }
        }
        else
        {
            if (a == 0)
            {
                anim.SetBool("e", false);
            }
            else if (a == 1)
            {
                anim.SetBool("e", true);
            }
            anim.SetBool("run", false);
            anim.SetBool("run2", false);
        }

        isJump = Physics2D.OverlapPoint(jumpCheck.position, jump);
        isJump2 = Physics2D.OverlapPoint(jumpCheck2.position, jump);
        isJump3 = Physics2D.OverlapPoint(jumpCheck3.position, jump);
        if (transform.position.x < player.transform.position.x)
        {
            sr.flipX = true;
        }
        else if (transform.position.x > player.transform.position.x)
        {
            sr.flipX = false;
        }
        if (isJump == true && isGrounded2 == true && isJump3 == true && Vector2.Distance(transform.position, player.transform.position) < rundistance && Vector2.Distance(transform.position, player.transform.position) > stoppingdistance)
        {
            rb.velocity = Vector2.up * jumpForse;
            isGrounded2 = false;
            isGroundedfloat = startisGroundedfloat;
            isJump = false;
            isJump3 = false;
        }
        if (isJump2 == true && isGrounded2 == true && isJump3 == true && Vector2.Distance(transform.position, player.transform.position) < rundistance && Vector2.Distance(transform.position, player.transform.position) > stoppingdistance)
        {
            rb.velocity = Vector2.up * jumpForse;
            isGrounded2 = false;
            isGroundedfloat = startisGroundedfloat;
            isJump2 = false;
            isJump3 = false;
        }
        if (d2 > stoppingdistance && d2 < rundistance)
        {
            audio3 = audio4;
            if (gameObject.transform.position.x > -20 && gameObject.transform.position.x < 0 && gameObject.transform.position.x < player.transform.position.x)
            {
                transform.position = this.transform.position;
                a1 = false;
                audio1.Stop();
                audio2 = false;
            }
            else if (gameObject.transform.position.x > 0 && gameObject.transform.position.x < 50 && gameObject.transform.position.x > player.transform.position.x)
            {
                transform.position = this.transform.position;
                a1 = false;
                audio1.Stop();
                audio2 = false;
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
                a1 = true;
                if (isJump3 == true && menu.pause == false)
                {
                    if (audio2 == false)
                    {
                        audio1.Play();
                        audio2 = true;
                    }

                }
                else
                {
                    audio1.Stop();
                    audio2 = false;
                }
            }
        }
        else
        {
            transform.position = this.transform.position;
            a1 = false;
            audio3 -= Time.deltaTime;
            if(audio3 <= 0)
            {
                audio1.Stop();
                audio2 = false;
                
            }
            if (menu.pause == true)
            {
                audio1.Stop();
                audio2 = false;
            }
        }
        if(timeBtwShots <= 0)
        {
            if (d2 <= shotDistance && d4 <= 2)
            {
                if(critical3 > s9)
                {
                    PlayerHP.healt -= Damage6 * s8 * s10 * 0;
                    critical3 = Random.Range(0f, 1f);
                    player2.textHP.text = "-0";
                    player2.textHPtime = player2.textHPtimeStart;
                }
                else
                {
                    PlayerHP.healt -= (int)(Damage6 * s8 * s10);
                    critical3 = Random.Range(0f, 1f);
                    player2.textHP.text = "-" + texthpF.ToString();
                    player2.textHPtime = player2.textHPtimeStart;
                }
                player2.regainTime = player2.regainStartTime;
                timeBtwShots = startTimeBtwShots;
                a2 = true;

            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        if (player2.C == true && d2 <= ShotDistance2 && d4 <= 2)
        {
            if (transform.position.x > player.transform.position.x)
            {
                if (player2.isLookingRight == true)
                {
                    if (skills.level6 == 1 && critical > 0.9f)
                    {
                        HP -= (int)(Damage * s3 * 2 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * 2 * s6 * 0.5f);
                        }
                    }
                    else if (skills.level6 == 2 && critical > 0.8f)
                    {
                        HP -= (int)(Damage * s3 * 2 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * 2 * s6 * 0.5f);
                        }
                    }
                    else if (skills.level6 == 3 && critical > 0.7f)
                    {
                        HP -= (int)(Damage * s3 * 2 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * 2 * s6 * 0.5f);
                        }
                    }
                    else
                    {
                        HP -= (int)(Damage * s3 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * s6 * 0.5f);
                        }
                    }
                    player2.C = false;
                    text1.text = "-" + Damagetext.ToString();
                    t = tStart;
                    critical = Random.Range(0f, 1f);
                    critical2 = Random.Range(0f, 1f);
                }
            }
            else
            {
                if (player2.isLookingRight == false)
                {

                    if (skills.level6 == 1 && critical > 0.9f)
                    {
                        HP -= (int)(Damage * s3 * 2 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * 2 * s6 * 0.5f);
                        }
                    }
                    else if (skills.level6 == 2 && critical > 0.8f)
                    {
                        HP -= (int)(Damage * s3 * 2 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * 2 * s6 * 0.5f);
                        }
                    }
                    else if (skills.level6 == 3 && critical > 0.7f)
                    {
                        HP -= (int)(Damage * s3 * 2 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * 2 * s6 * 0.5f);
                        }
                    }
                    else
                    {
                        HP -= (int)(Damage * s3 * s6);
                        if (critical2 > s7)
                        {
                            PlayerHP.healt += (int)(Damage * s3 * s6 * 0.5f);
                        }
                    }
                    player2.C = false;
                    text1.text = "-" + Damagetext.ToString();
                    t = tStart;
                    critical = Random.Range(0f, 1f);
                    critical2 = Random.Range(0f, 1f);
                }
            }
        }
        if (t <= 0)
        {
            text1.text = "";
        }
        t -= Time.deltaTime;
        if (HP <= 0)
        {
            Death();
        }
        timeBtwShots2 -= Time.deltaTime;
        indexB = inventory.index2;
        if (isGroundedfloat <= 0)
        {
            isGrounded2 = true;
        }
        isGroundedfloat -= Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage * s * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage * s * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage * s * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage * s * s6);
            }
            text1.text = "-" + Damagetext2.ToString();
            t = tStart;
            critical = Random.Range(0f, 1f);
        }
        if (other.CompareTag("Bullet2"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage2 * s4 * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage2 * s4 * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage2 * s4 * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage2 * s4 * s6);
            }
            text1.text = "-" + Damagetext3.ToString();
            t = tStart;
            critical = Random.Range(0f, 1f);
        }
        if (other.CompareTag("Bullet3"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage3 * s4 * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage3 * s4 * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage3 * s4 * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage3 * s4 * s6);
            }
            text1.text = "-" + Damagetext4.ToString();
            t = tStart;
            critical = Random.Range(0f, 1f);
        }
        if (other.CompareTag("Bullet4"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage4 * s2 * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage4 * s2 * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage4 * s2 * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage4 * s2 * s6);
            }
            text1.text = "-" + Damagetext5.ToString();
            t = tStart;
            critical = Random.Range(0f, 1f);
        }
        if (other.CompareTag("Bullet5"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage5 * s5 * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage5 * s5 * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage5 * s5 * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage5 * s5 * s6);
            }
            text1.text = "-" + Damagetext6.ToString();
            t = tStart;
            critical = Random.Range(0f, 1f);
        }
        if (other.CompareTag("Bullet6"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage2 * s * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage2 * s * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage2 * s * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage2 * s * s6);
            }
            text1.text = "-" + Damagetext7.ToString();
            t = tStart;
            critical = Random.Range(0, 1);
        }
        if (other.CompareTag("Bullet7"))
        {
            if (skills.level6 == 1 && critical > 0.9f)
            {
                HP -= (int)(Damage * s2 * 2 * s6);
            }
            else if (skills.level6 == 2 && critical > 0.8f)
            {
                HP -= (int)(Damage * s2 * 2 * s6);
            }
            else if (skills.level6 == 3 && critical > 0.7f)
            {
                HP -= (int)(Damage * s2 * 2 * s6);
            }
            else
            {
                HP -= (int)(Damage * s2 * s6);
            }
            text1.text = "-" + Damagetext8.ToString();
            t = tStart;
            critical = Random.Range(0f, 1f);
        }
    }
    void Death()
    {
        Vector3 drop7 = new Vector3(transform.position.x + drop6, transform.position.y, transform.position.z);
        Vector3 drop8 = new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z);
        if (drop4 > 0.4f)
        {
            Instantiate(drop, transform.position, Quaternion.identity);
            if (critical3 > s11)
            {
                Instantiate(drop, drop8, Quaternion.identity);
            }
        }
        else
        {

        }
        level.levelpoint2 += levelS * levelS2 * adsmenu2;
        level.text2.text = "+" + levelS3.ToString();
        level.textTime = level.textTimeStart;
        Instantiate(drop2, drop7, Quaternion.identity);
        player2.EnemyCount -= 1;
        if (training1.training2i == 1)
        {
            training1.training3i += 1;
        }
        Destroy(gameObject);
    }
    void a3()
    {
        a2 = false;
    }
}
