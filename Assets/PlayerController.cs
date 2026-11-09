using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int EnemyCount;
    public float EnemySpawnTime;
    public int language;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public Transform ladderCheck;
    public LayerMask whatIsLadder;
    public bool isGrounded;
    public float jumpForce;
    public float speed;
    Rigidbody2D rb;
    public bool isLookingRight;
    public Joystick joystick;
    public float moveInput;
    public GameObject gun;
    public float rotateZ;
    public Joystick weaponjoystick;
    public Transform weaponPose;
    public bool onoff;
    public bool isLookingRight2;
    public float rotateZ2;
    public GameObject bullet3;
    public GameObject bulletSpawn;
    public GameObject bullet2;
    public float cooldown2;
    public float startCooldown2;
    public float cooldown5;
    public float startCooldown5;
    public float a;
    public bool C;
    public float Ctime;
    public float startCtime;
    public float cooldown3;
    public float startcooldown3;
    public bool gunon;
    public GameObject item;
    public Pickup pickup2;
    public bool onpickup;
    public Inventory inventory;
    public GameObject pickupButton;
    public bool onpickup2;
    public Pausemenu pausemenu;
    public InventoryOpen inventoryOpen;
    public bool shotanimation;
    public float weapon;
    public bool shotanimation2;
    public bool shotanimation3;
    public bool jumpready;
    public float jumptime;
    public float startjumptime;
    public bool shotanimation4;
    public GameObject Shoteffect;
    public GameObject Shoteffect1;
    public float Shoteffectdistance;
    public float Shoteffectdistance2;
    public GameObject Shoteffect2;
    public GameObject Shoteffect3;
    public float Shoteffectdistance3;
    public float Shoteffectdistance4;
    public float Shoteffectdistance1;
    public bool j1;
    public bool j2;
    public bool isLadder;
    public float speed2;
    public GameObject bg;
    public bool bg2;
    public float h;
    public float h2;
    public float starth;
    public float StartCooldown2i;
    public float StartCooldown5i;
    public float startcooldown3i;
    public float StartCooldown5i2;
    public bool shotanimation5;
    public bool shotanimation6;
    public float StartCooldown5i3;
    public float Shoteffectdistance5;
    public float StartCooldown5i4;
    public float StartCooldown5i5;
    public float StartCooldown5i6;
    public float StartCooldown5i7;
    public float StartCooldown5i8;
    public bool shotanimation7;
    public bool shotanimation8;
    public bool shotanimation9;
    public bool shotanimation10;
    public bool shotanimation11;
    public bool shotanimation12;
    public bool shotanimation13;
    public float Shoteffectdistance6;
    public float Shoteffectdistance7;
    public float Shoteffectdistance8;
    public float Shoteffectdistance9;
    public float Shoteffectdistance10;
    public float Shoteffectdistance11;
    public GameObject bullet4;
    public GameObject bullet5;
    public GameObject bullet6;
    public GameObject bullet7;
    public GameObject bullet8;
    public GameObject bullet9;
    public GameObject bullet10;
    public GameObject bullet11;
    public GameObject bullet12;
    public GameObject bullet13;
    public GameObject bullet14;
    public GameObject bullet15;
    public float stime;
    public float startStime;
    public SpriteRenderer sr;
    public float s;
    public Skills skills;
    public float regain;
    public float regainTime;
    public float regainStartTime;
    public float regainTime2;
    public float regainStartTime2;
    public float verticalMove;
    public Text textHP;
    public float textHPtime;
    public float textHPtimeStart;
    public AudioSource audio1;
    public bool audio2;
    public AudioClip audio3;
    public AudioSource audio4;
    public AudioSource audio5;
    public AudioSource audio6;
    public AudioSource audio7;
    public AudioSource audio8;
    public AudioSource audio9;
    public AudioSource audio10;
    public AudioSource audio11;
    public training training1;
    // Start is called before the first frame update
    void Start()
    {
        skills = gameObject.GetComponent<Skills>();
        pausemenu = gameObject.GetComponent<Pausemenu>();
        onoff = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        cooldown2 = startCooldown2;
        cooldown5 = startCooldown5;
        C = false;
        Ctime = startCtime;
        cooldown3 = startcooldown3;
        inventory = gameObject.GetComponent<Inventory>();
        if (PlayerPrefs.HasKey("PosX") && PlayerPrefs.HasKey("PosY") && PlayerPrefs.HasKey("PosZ"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
        }
        else
        {

        }
        if (PlayerPrefs.HasKey("language"))
        {
            language = PlayerPrefs.GetInt("language");
        }
        else
        {
            language = 0;
        }
        jumptime = startjumptime;
        h = starth;
        stime = startStime;
        regainTime = regainStartTime;
        regainTime2 = regainStartTime2;
        textHPtime = textHPtimeStart;
        EnemySpawnTime = Random.Range(10, 15);
        training1 = gameObject.GetComponent<training>();
    }

    // Update is called once per frame

    void Update()
    {
        PlayerPrefs.SetInt("language", language);
        EnemySpawnTime -= Time.deltaTime;
        textHPtime -= Time.deltaTime;
        if(textHPtime <= 0)
        {
            textHP.text = "";
        }
        if(skills.levelB8 == 1)
        {
            regain = 1;
        }
        else if(skills.levelB8 == 2)
        {
            regain = 2;
        }
        else
        {
            regain = 0;
        }
        regainTime -= Time.deltaTime;
        if(regainTime <= 0)
        {
            regainTime2 -= Time.deltaTime;
        }
        else
        {
            regainTime2 = regainStartTime2;
        }
        if(regainTime2 <= 0)
        {
            PlayerHP.healt += regain;
            regainTime2 = regainStartTime2;
        }
        if(skills.levelB5 == 1)
        {
            s = 0.5f;
        }
        else if(skills.levelB5 == 2)
        {
            s = 0f;
        }
        else
        {
            s = 1f;
        }
        if(C == true)
        {
            stime -= Time.deltaTime;
        }
        if(stime <= 0)
        {
            C = false;
        }
        if(inventory.index2 == 0)
        {
            startCooldown2 = StartCooldown2i;
            startcooldown3 = startcooldown3i;
        }
        if (inventory.index2 == 10)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i;
        }
        if (inventory.index2 == 20)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i2;
        }
        if(inventory.index2 == 30)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i3;
        }
        if (inventory.index2 == 40)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i4;
        }
        if (inventory.index2 == 50)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i5;
        }
        if (inventory.index2 == 60)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i6;
        }
        if (inventory.index2 == 70)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i7;
        }
        if (inventory.index2 == 80)
        {
            startCooldown2 = StartCooldown2i;
            startCooldown5 = StartCooldown5i8;
        }

        if (h <= 0)
        {
            PlayerHP.healt -= h2 * s;
            h = starth;
            regainTime = regainStartTime;
        }
        if(bg2 == true)
        {
            h -= Time.deltaTime;
        }
        else
        {
            h = starth;
        }
        bg.SetActive(bg2);
        if (gameObject.transform.position.x < -215)
        {
            bg2 = true;
        }
        if(gameObject.transform.position.x > 300)
        {
            bg2 = true;
        }
        if(gameObject.transform.position.x > -215 && gameObject.transform.position.x < 300)
        {
            bg2 = false;
        }
        if (isGrounded == true)
        {
            jumptime -= Time.deltaTime;
        }
        if (jumptime <= 0)
        {
            jumpready = true;
        }
        else
        {
            jumpready = false;
        }

        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("PosX", transform.position.x);
        PlayerPrefs.SetFloat("PosY", transform.position.y);
        PlayerPrefs.SetFloat("PosZ", transform.position.z);
        if(j1 == false)
        {
            weapon = 0;
        }
        else if(pausemenu.off == false)
        {
            weapon = 0;
        }
        else
        {
            weapon = weaponjoystick.Horizontal;
        }
       
        if (weaponjoystick.Horizontal > .0f)
        {
            j2 = false;
            verticalMove = 0;
        }
        else if (weaponjoystick.Horizontal < .0f)
        {
            j2 = false;
            verticalMove = 0;
        }
        else
        {
            j2 = true;
            verticalMove = joystick.Vertical;
        }
        if (isGrounded == false)
        {
            j1 = false;
        }
        else
        {
            j1 = true;
        }
        if (onpickup == true && pausemenu.off == true)
        {
            onpickup2 = true;
        }
        else if(onpickup == true && pausemenu.off == false)
        {
            onpickup2 = false;
        }
        else if (onpickup == false && pausemenu.off == true)
        {
            onpickup2 = false;
        }
        else if (onpickup == false && pausemenu.off == false)
        {
            onpickup2 = false;
        }
        item = GameObject.FindGameObjectWithTag("Item");
        if (item != null)
        {
            onpickup = true;
            pickup2 = item.GetComponent<Pickup>();
        }
        else
        {
            onpickup = false;
        }
        pickupButton.SetActive(onpickup2);
        
        if (gunon == true)
        {
            if (weapon > 0)
            {
                onoff = true;
            }
            else if (weapon < 0)
            {
                onoff = true;
            }
            else
            {
                onoff = false;
            }
            if (rotateZ > 50 && rotateZ < 130)
            {
                onoff = false;
            }
            if (rotateZ < -50 && rotateZ  > -130)
            {
                onoff = false;
            }
        }
        else
        {
            onoff = false;
        }
        if(onoff == true)
        {
            gun.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.7f);
        }
        else
        {
            gun.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
        }
        if (isGrounded == true && verticalMove >= .5f && jumpready == true)
        {
            jumptime = startjumptime;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        if (weapon > 0)
        {
            if (gunon == true)
            {
                if (isLookingRight == true && cooldown5 <= 0 && cooldown2 <= 0)
                {
                    Shot();
                }
                if (isLookingRight == false && cooldown5 <= 0 && cooldown2 <= 0)
                {
                    Shot2();
                }
            }
            else
            {
                Shot3();
            }
        }
        if (weapon < 0)
        {
            if (gunon == true)
            {
                if (isLookingRight == true && cooldown2 <= 0 && cooldown5 <= 0)
                {
                    Shot();
                }
                if (isLookingRight == false && cooldown2 <= 0 && cooldown5 <= 0)
                {
                    Shot2();
                }
            }
            else
            {
                Shot3();
            }
        }
        if (weaponjoystick.Horizontal == .0f)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
        }
        if (inventory.index2 == 10)
        {
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if(weapon > 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    shotanimation = false;
                    shotanimation2 = true;
                    shotanimation3 = false;
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    shotanimation = false;
                    shotanimation2 = false;
                    shotanimation3 = true;
                }
                else
                {
                    shotanimation = true;
                    shotanimation2 = false;
                    shotanimation3 = false;
                }
            }
            if(weapon < 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    shotanimation = false;
                    shotanimation2 = true;
                    shotanimation3 = false;
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    shotanimation = false;
                    shotanimation2 = false;
                    shotanimation3 = true;
                }
                else
                {
                    shotanimation = true;
                    shotanimation2 = false;
                    shotanimation3 = false;
                }
            }
            

        }
        else if(inventory.index2 == 20)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if (weapon > 0)
            {
                shotanimation5 = true;
            }
            if(weapon < 0)
            {
                shotanimation5 = true;
            }
        }
        else if(inventory.index2 == 30)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if (weapon > 0)
            {
                shotanimation6 = true;
            }
            if (weapon < 0)
            {
                shotanimation6 = true;
            }
        }
        else if (inventory.index2 == 40)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if (weapon > 0)
            {
                shotanimation7 = true;
            }
            if (weapon < 0)
            {
                shotanimation7 = true;
            }
        }
        else if (inventory.index2 == 50)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if (weapon > 0)
            {
                shotanimation8 = true;
            }
            if (weapon < 0)
            {
                shotanimation8 = true;
            }
        }
        else if (inventory.index2 == 60)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if (weapon > 0)
            {
                shotanimation9 = true;
            }
            if (weapon < 0)
            {
                shotanimation9 = true;
            }
        }
        else if (inventory.index2 == 70)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;
            if (weapon > 0)
            {
                shotanimation10 = true;
            }
            if (weapon < 0)
            {
                shotanimation10 = true;
            }
        }
        else if (inventory.index2 == 80)
        {
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation4 = false;
            shotanimation5 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            if (weapon > 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    shotanimation11 = false;
                    shotanimation12 = true;
                    shotanimation13 = false;
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    shotanimation11 = false;
                    shotanimation12 = false;
                    shotanimation13 = true;
                }
                else
                {
                    shotanimation11 = true;
                    shotanimation12 = false;
                    shotanimation13 = false;
                }
            }
            if (weapon < 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    shotanimation11 = false;
                    shotanimation12 = true;
                    shotanimation13 = false;
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    shotanimation11 = false;
                    shotanimation12 = false;
                    shotanimation13 = true;
                }
                else
                {
                    shotanimation11 = true;
                    shotanimation12 = false;
                    shotanimation13 = false;
                }
            }
            

        }
        else
        {
            shotanimation5 = false;
            shotanimation = false;
            shotanimation2 = false;
            shotanimation3 = false;
            shotanimation6 = false;
            shotanimation7 = false;
            shotanimation8 = false;
            shotanimation9 = false;
            shotanimation10 = false;
            shotanimation11 = false;
            shotanimation12 = false;
            shotanimation13 = false;

        }


        if (onoff == true)
        {
            cooldown2 -= Time.deltaTime;
        }
        if (onoff == false)
        {
            cooldown2 = startCooldown2;
        }
        cooldown5 -= Time.deltaTime;
        cooldown3 -= Time.deltaTime;



        isGrounded = Physics2D.OverlapPoint(groundCheck.position, whatIsGround);
        if(j2 == false)
        {
            moveInput = 0;
        }
        else if(pausemenu.off == false)
        {
            moveInput = 0;
        }
        else
        {
            moveInput = joystick.Horizontal;
        }
        if (isLadder == false)
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            rb.gravityScale = 1;
        }
        else
        {
            rb.velocity = new Vector2(moveInput * speed * 1/2, verticalMove * speed2);
            rb.gravityScale = 0;
        }
        if(moveInput > 0.1f  && isGrounded == true && isLadder == false)
        {
            
            if (audio2 == false)
            {
                audio2 = true;
                audio1.Play();
            }
        }
        else if(moveInput < -0.1f && isGrounded == true && isLadder == false)
        {
            if (audio2 == false)
            {
                audio2 = true;
                audio1.Play();
            }
        }
        else
        {
            audio1.Stop();
            audio2 = false;
        }
        isLadder = Physics2D.OverlapPoint(ladderCheck.position, whatIsLadder);
        if (moveInput > 0 && !isLookingRight) TurnThePlayer();
        if (moveInput < 0 && isLookingRight) TurnThePlayer();
        if (weaponjoystick.Horizontal > 0 && !isLookingRight) TurnThePlayer();
        if (weaponjoystick.Horizontal < 0 && isLookingRight) TurnThePlayer();
        if (isLookingRight == true)
        {
            rotateZ = Mathf.Atan2(weaponjoystick.Vertical, weaponjoystick.Horizontal) * Mathf.Rad2Deg;
        }
        if (isLookingRight == false)
        {
            rotateZ = Mathf.Atan2(weaponjoystick.Vertical, weaponjoystick.Horizontal) * Mathf.Rad2Deg;
        }
        weaponPose.rotation = Quaternion.Euler(0, 0, rotateZ);

        if(weapon > 0)
        {
            moveInput = 0;
        }
        if(weapon < 0)
        {
            moveInput = 0;
        }

    }
    
    void TurnThePlayer()
    {
        isLookingRight = !isLookingRight;
        //transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        sr.flipX = !sr.flipX;
    }
    void TurnTheJoystick()
    {
        isLookingRight2 = !isLookingRight2;
        weaponjoystick.transform.localScale = new Vector3(weaponjoystick.transform.localScale.x * -1, weaponjoystick.transform.localScale.y * -1, weaponjoystick.transform.localScale.z);
    }
    public void Shot()
    {
        cooldown5 = startCooldown5;
        if(inventory.index2 == 10)
        {
            Instantiate(bullet3, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            audio4.Play();
            if(weapon > 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
            if(weapon < 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }

        }
        else if (inventory.index2 == 80)
        {
            Instantiate(bullet13, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            audio5.Play();
            if (weapon > 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
            if (weapon < 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
        }
        else if (inventory.index2 == 20)
        {
            audio6.Play();
            Instantiate(bullet5, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
            if(weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
        }
        else if (inventory.index2 == 30)
        {
            audio7.Play();
            Instantiate(bullet5, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance1, transform.position.y + Shoteffectdistance5, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance1, transform.position.y + Shoteffectdistance5, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
        }
        else if (inventory.index2 == 40)
        {
            audio8.Play();
            Instantiate(bullet7, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
        }
        else if (inventory.index2 == 50)
        {
            audio9.Play();
            Instantiate(bullet15, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance7, transform.position.y + Shoteffectdistance6, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance7, transform.position.y + Shoteffectdistance6, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
        }
        else if (inventory.index2 == 60)
        {
            audio10.Play();
            Instantiate(bullet9, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance8, transform.position.y + Shoteffectdistance9, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance8, transform.position.y + Shoteffectdistance9, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.identity);
            }
        }
        else if (inventory.index2 == 70)
        {
            audio11.Play();
            Instantiate(bullet11, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance10, transform.position.y + Shoteffectdistance11, transform.position.z);
                Instantiate(Shoteffect, playerPos, Quaternion.identity);
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x + Shoteffectdistance10, transform.position.y + Shoteffectdistance11, transform.position.z);
                Instantiate(Shoteffect, playerPos, Quaternion.identity);
            }
        }

    }
    public void Shot2()
    {
        
        cooldown5 = startCooldown5;
        if(inventory.index2 == 10)
        {
            audio4.Play();
            Instantiate(bullet2, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon > 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
            if (weapon < 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
        }
        else if (inventory.index2 == 80)
        {
            audio5.Play();
            Instantiate(bullet12, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon > 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
            if (weapon < 0)
            {
                if (rotateZ >= 15 && rotateZ <= 165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance3, transform.position.z);
                    Instantiate(Shoteffect2, playerPos, Quaternion.identity);
                }
                else if (rotateZ <= -15 && rotateZ >= -165)
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance4, transform.position.z);
                    Instantiate(Shoteffect3, playerPos, Quaternion.identity);
                }
                else
                {
                    Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance, transform.position.y + Shoteffectdistance2, transform.position.z);
                    Instantiate(Shoteffect, playerPos, Quaternion.identity);
                }
            }
        }
        else if (inventory.index2 == 20)
        {
            audio6.Play();
            Instantiate(bullet4, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
            if(weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
        }
        else if (inventory.index2 == 30)
        {
            audio7.Play();
            Instantiate(bullet4, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance1, transform.position.y + Shoteffectdistance5, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance1, transform.position.y + Shoteffectdistance5, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
        }
        else if (inventory.index2 == 40)
        {
            audio8.Play();
            Instantiate(bullet6, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance1, transform.position.y, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
        }
        else if (inventory.index2 == 50)
        {
            audio9.Play();
            Instantiate(bullet14, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance7, transform.position.y + Shoteffectdistance6, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance7, transform.position.y + Shoteffectdistance6, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
        }
        else if (inventory.index2 == 60)
        {
            audio10.Play();
            Instantiate(bullet8, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance8, transform.position.y + Shoteffectdistance9, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance8, transform.position.y + Shoteffectdistance9, transform.position.z);
                Instantiate(Shoteffect1, playerPos, Quaternion.Euler(0, 0, 180));
            }
        }
        else if (inventory.index2 == 70)
        {
            audio11.Play();
            Instantiate(bullet10, bulletSpawn.transform.position, Quaternion.Euler(0, 0, rotateZ));
            if (weapon < 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance10, transform.position.y + Shoteffectdistance11, transform.position.z);
                Instantiate(Shoteffect, playerPos, Quaternion.Euler(0, 0, 180));
            }
            if (weapon > 0)
            {
                Vector3 playerPos = new Vector3(transform.position.x - Shoteffectdistance10, transform.position.y + Shoteffectdistance11, transform.position.z);
                Instantiate(Shoteffect, playerPos, Quaternion.Euler(0, 0, 180));
            }
        }
    }
    public void Shot3()
    {
        if(cooldown3 <= 0)
        {
            C = true;
            cooldown3 = startcooldown3;
            shotanimation4 = true;
            stime = startStime;
        }
    }
    public void pickup3()
    {
        if(onpickup == true)
        {
            for (int i = 0; i < pickup2.Lenght; i++)
            {
                if (inventory.b[i] == 2)
                {
                    inventory.b[i] = pickup2.t;
                    Instantiate(pickup2.slotButton, inventory.slots[i].transform);
                    if(pickup2.trainingitem == 2 && training1.training2i == 2)
                    {
                        training1.training3i2 += 1;
                    }
                    Destroy(item);
                    break;
                }
            }
        }
    }
    public void a4()
    {
        shotanimation4 = false;
    }

}
