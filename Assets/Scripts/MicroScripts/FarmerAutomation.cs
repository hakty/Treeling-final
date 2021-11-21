using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmerAutomation : MonoBehaviour
{
    public Text RCText;
    public GameObject RC;
    private float coins;
    private bool autoHarvest = false;

    //public BoxCollider2D appleH, bananaH,orangeH,lemonH,coconutH,cocoaH;
    [SerializeField] private Image imageCD;
    private bool isCD = false;
    private float CDTime = 600.0f; //10min active
    private float CDTimer = 0.0f;

    void Start()
    {
        imageCD.fillAmount = 0.0f;
    }

    void Update()
    {
        if(isCD) {
            applyCooldown();
        }
        coins = RCText.GetComponent<CoinText>().currentCoins;
        //print(gameObject.name);
        harvest();
    }
    void applyCooldown() {
        CDTimer -= Time.deltaTime;

        if(CDTimer < 0.0f) {
            isCD = false;
            //textCD.gameObject.SetActive(false);
            imageCD.fillAmount = 0.0f;
        }
        else {
            //textCD.text = Mathf.RoundToInt(CDTimer).ToString();
            imageCD.fillAmount = CDTimer / CDTime;
        }
    }
    public void harvestUsed() {
        if(isCD) {

        }
        else {
            isCD = true;
            CDTimer = CDTime;
        }
    }

    public void OnMouseDown() {
        if(gameObject.name == "AutoHarvest") {
            if(coins < 50000) {
                coins = RCText.GetComponent<CoinText>().currentCoins;
            } else {
                coins = RCText.GetComponent<CoinText>().currentCoins -= 50000;
                autoHarvest = true;
                harvestUsed();
                if(isCD) applyCooldown(); 
                StartCoroutine(harvestTimer());
            }
        }
    }
    IEnumerator harvestTimer() {
        yield return new WaitForSeconds(CDTime);
        autoHarvest = false;
    }
    void harvest() {
        if(autoHarvest && AppleTree.stage3) { 
            AppleTree collect = FindObjectOfType<AppleTree>();
            collect.OnMouseDown();
        }
        //add the rest of the fruit 
        if(autoHarvest && BananaTree.stage3) {
            BananaTree collect = FindObjectOfType<BananaTree>();
            collect.OnMouseDown();
        }
        if(autoHarvest && OrangeTree.stage3) {
            OrangeTree collect = FindObjectOfType<OrangeTree>();
            collect.OnMouseDown();
        }
        if(autoHarvest && LemonTree.stage3) {
            LemonTree collect = FindObjectOfType<LemonTree>();
            collect.OnMouseDown();
        }
        if(autoHarvest && CoconutTree.stage3) {
            CoconutTree collect = FindObjectOfType<CoconutTree>();
            collect.OnMouseDown();
        }

        if(autoHarvest && CocoaTree.stage3) {
            CocoaTree collect = FindObjectOfType<CocoaTree>();
            collect.OnMouseDown();
        }
    }
}
