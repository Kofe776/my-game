using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public PlayerController playerController;
    public bool isLookingRight2;
    public float height;
    public float width;
    public float z;
    public float z2;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        height = Camera.main.orthographicSize / z;
        width = height * Screen.width / Screen.height / z2;
        transform.localScale = new Vector3(width, height, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
        height = Camera.main.orthographicSize / z;
        width = height * Screen.width / Screen.height / z2;

    }
    void TurnTheBackground()
    {
        isLookingRight2 = !isLookingRight2;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
