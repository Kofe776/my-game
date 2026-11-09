using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Newgame : MonoBehaviour
{
    public GameObject buttuncontinue;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("m") && PlayerPrefs.HasKey("level"))
        {
            a = true;
        }
        else
        {
            a = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        buttuncontinue.SetActive(a);
    }
    public void newgame1()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.DeleteAll();
    }
    public void newgame2()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
