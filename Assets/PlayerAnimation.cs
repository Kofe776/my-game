using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    PlayerController PCon;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        PCon = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PCon.isGrounded == true && PCon.isLadder == false)
        {
            anim.SetBool("isJumping", false);
            anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        }
        if(PCon.isGrounded == false && PCon.isLadder == false)
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("isJumping", true);
        }
        if (PCon.isLadder == true)
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("isJumping", false);
            anim.SetBool("isLadder", true);

        }
        else
        {
            anim.SetBool("isLadder", false);
            anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        }
        if (PCon.shotanimation == true)
        {
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim", true);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if(PCon.shotanimation2 == true)
        {
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", true);
            anim.SetBool("Shotanim3", false);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);

        }
        else if (PCon.shotanimation3 == true)
        {
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if(PCon.shotanimation4 == true)
        {
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if(PCon.shotanimation5 == true)
        {
            anim.SetBool("Shotanim5", true);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim6", false);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation6 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim6", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation7 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim6", false);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", true);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation8 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim8", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation9 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim9", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation10 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim10", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation11 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim11", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation12 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim12", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim13", false);
        }
        else if (PCon.shotanimation13 == true)
        {
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim13", true);
            anim.SetFloat("Speed", 0);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim6", false);
        }
        else
        {
            anim.SetBool("Shotanim4", false);
            anim.SetBool("Shotanim", false);
            anim.SetBool("Shotanim2", false);
            anim.SetBool("Shotanim3", false);
            anim.SetBool("Shotanim5", false);
            anim.SetBool("Shotanim6", false);
            anim.SetBool("Shotanim7", false);
            anim.SetBool("Shotanim8", false);
            anim.SetBool("Shotanim9", false);
            anim.SetBool("Shotanim10", false);
            anim.SetBool("Shotanim11", false);
            anim.SetBool("Shotanim12", false);
            anim.SetBool("Shotanim13", false);
            anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        }
    }
}
