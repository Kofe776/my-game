using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On3 : MonoBehaviour
{
    public GameObject scope;
    public bool onoff;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        onoff = true;
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.rotateZ  > 0)
        {
            if (onoff == false)
            {
                onoff = false;
                Onoff();
            }
        }
        if (playerController.rotateZ < 0)
        {
            if(onoff == false)
            {
                onoff = false;
                Onoff();
            }
        }
        if (playerController.rotateZ == 0)
        {
            if (onoff == true)
            {
                onoff = false;
                Onoff();
            }
        }
    }
    public void Onoff()
    {
        scope.SetActive(onoff);
    }

}
