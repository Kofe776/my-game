using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour, IUnityAdsListener
{
    public trader trader1;
    public GameObject a1;
    public AdsMenu adsMenu1;
    public bool a2;
    public Pausemenu pausemenu;
    public bool a3;
    public int a4;
    public SkillsMenu skillsMenu1;
    public Level level1;
    public Skills skills1;
    public GameObject a5;
    public GameObject a6;
    public bool a7;
    // Start is called before the first frame update
    void Start()
    {
        pausemenu = gameObject.GetComponent<Pausemenu>();
        trader1 = gameObject.GetComponent<trader>();
        adsMenu1 = gameObject.GetComponent<AdsMenu>();
        skillsMenu1 = gameObject.GetComponent<SkillsMenu>();
        level1 = gameObject.GetComponent<Level>();
        skills1 = gameObject.GetComponent<Skills>();
        Advertisement.AddListener(this);
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4406017", false);
        }
        a2 = false;
        a3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Advertisement.IsReady())
        {
            if(pausemenu.off == true)
            {
                a2 = true;
            }
            else
            {
                a2 = false;
            }
        }
        else
        {
            a2 = false;
        }
        a1.SetActive(a2);
        a5.SetActive(a2);
        if(a2 == true)
        {
            a7 = false;
        }
        else
        {
            a7 = true;
        }
        a6.SetActive(a7);
    }
    public void ads1()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show("Rewarded_Android");
            a3 = true;
            a4 = 0;
        }
    }
    public void ads2()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show("Rewarded_Android");
            a4 = 1;
            a3 = true;
        }
    }
    void IUnityAdsListener.OnUnityAdsReady(string placementId)
    {

    }
    void IUnityAdsListener.OnUnityAdsDidError(string message)
    {

    }
    void IUnityAdsListener.OnUnityAdsDidStart(string placementId)
    {

    }
    void IUnityAdsListener.OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            a3 = false;
            if(a4 == 0)
            {
                if (adsMenu1.menuads3 == 0 && adsMenu1.menuads2 <= 0)
                {
                    adsMenu1.menuads2 = adsMenu1.menuads6;
                    adsMenu1.a4 = true;
                    adsMenu1.menuads3 = Random.Range(0, 2);
                }
                else
                {
                    trader1.money += 400;
                    adsMenu1.a3 = true;
                    adsMenu1.menuads3 = Random.Range(0, 2);
                }
            }
            else
            {
                skillsMenu1.on3 = false;
                skills1.skillPoints = level1.PlayerLevel - 1;
                skills1.level = 0;
                skills1.level2 = 0;
                skills1.level3 = 0;
                skills1.level4 = 0;
                skills1.level5 = 0;
                skills1.level6 = 0;
                skills1.level7 = 0;
                skills1.level8 = 0;
                skills1.levelB = 0;
                skills1.levelB2 = 0;
                skills1.levelB3 = 0;
                skills1.levelB4 = 0;
                skills1.levelB5 = 0;
                skills1.levelB6 = 0;
                skills1.levelB7 = 0;
                skills1.levelB8 = 0;
                skills1.levelC = 0;
                skills1.levelC2 = 0;
                skills1.levelC3 = 0;
                skills1.levelC4 = 0;
                skills1.levelC5 = 0;
                skills1.levelC6 = 0;
            }
            
            
        }
        else if (showResult == ShowResult.Skipped)
        {
            a3 = false;
        }
        else if (showResult == ShowResult.Failed)
        {
            a3 = false;
        }
    }
}
