using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public static bool WaterActive;
    public static bool FertiliserActive;
    public static bool FruitbActive;
    public static bool TreegActive;

    [SerializeField] private Image imageCoolDown;
   // [SerializeField] private Text textCD;

    private bool isCD = false;
    private float CDTime = 100.0f;
    private float CDTimer = 0.0f;

    //private float activeTimer = 100.0f;
    public Text waterTxt,fertiliserTxt, fruitBTxt, treeGTxt;

    void Start() {
       //textCD.gameObject.SetActive(false);
       imageCoolDown.fillAmount = 0.0f;
    }

    void Update() {
        //if(Input.GetKeyDown(KeyCode.E)) {
        //    itemUsed();
        //}
        if(isCD) {
            applyCooldown();
        }
    }
    
    public void OnMouseDown() {
        //print(gameObject.name);
        //if(!Input.GetMouseButtonDown(0)) return;
        if(gameObject.name == "Water") {
            //print("clicked on water");
            if(BuyItem.water < 1) {
                //u dont have any water in inventory
            } else {
            WaterUsed();
            if(isCD) applyCooldown(); 
            WaterActive = true;
            StartCoroutine(WaterTimer());
            }
            waterTxt.text = "" + BuyItem.water;
        }
        if(gameObject.name == "Fertiliser") {
            //print("clicked on Fertiliser");
             if(BuyItem.fertiliser < 1) {
                //u dont have any water in inventory
            } else {
            FertiliserUsed();
            if(isCD) applyCooldown();
            FertiliserActive = true;
            StartCoroutine(FertiliserTimer());
            }
            fertiliserTxt.text = "" + BuyItem.fertiliser;
        }
        if(gameObject.name == "FruitBooster") {
            //print("clicked on fruitbooster");
             if(BuyItem.fruitB < 1) {
                //u dont have any water in inventory
            } else {
            FruitBUsed();
            if(isCD) applyCooldown();
            //use item
            FruitbActive = true;
            StartCoroutine(FruitbTimer());
            }
            fruitBTxt.text = "" + BuyItem.fruitB;
        }
        if(gameObject.name == "Tree Growth") {
            //print("clicked on tree growth");
            if(BuyItem.treeG < 1) {
                //u dont have any water in inventory
            } else {
            TreeGUsed();
            if(isCD) applyCooldown();
            TreegActive = true;
            StartCoroutine(TreeGTimer());
            }
            treeGTxt.text = "" + BuyItem.treeG;
            //use item
        }
    }

    void applyCooldown() {
        CDTimer -= Time.deltaTime;

        if(CDTimer < 0.0f) {
            isCD = false;
            //textCD.gameObject.SetActive(false);
            imageCoolDown.fillAmount = 0.0f;
        }
        else {
            //textCD.text = Mathf.RoundToInt(CDTimer).ToString();
            imageCoolDown.fillAmount = CDTimer / CDTime;
        }
    }

    public void WaterUsed() {
        if(isCD) {
            //user has clicked item while in cooldown so do nothing
        }
        else {
            BuyItem.water--;
            isCD = true;
            //textCD.gameObject.SetActive(true);
            CDTimer = CDTime;
        }
    }
    public void FertiliserUsed() {
        if(isCD) {
            //user has clicked item while in cooldown so do nothing
        }
        else {
            BuyItem.fertiliser--;
            isCD = true;
            //textCD.gameObject.SetActive(true);
            CDTimer = CDTime;
        }
    }
    public void FruitBUsed() {
        if(isCD) {
            //user has clicked item while in cooldown so do nothing
        }
        else {
            BuyItem.fruitB--;
            isCD = true;
            //textCD.gameObject.SetActive(true);
            CDTimer = CDTime;
        }
    }
    public void TreeGUsed() {
        if(isCD) {
            //user has clicked item while in cooldown so do nothing
        }
        else {
            BuyItem.treeG--;
            isCD = true;
            //textCD.gameObject.SetActive(true);
            CDTimer = CDTime;
        }
    }

    IEnumerator WaterTimer() {
        yield return new WaitForSeconds(CDTime);
        WaterActive = false;
    }

    IEnumerator FertiliserTimer() {
        yield return new WaitForSeconds(CDTime);
        FertiliserActive = false;
    }
    IEnumerator FruitbTimer() {
        yield return new WaitForSeconds(CDTime);
        FruitbActive = false;
    }
    IEnumerator TreeGTimer() {
        yield return new WaitForSeconds(CDTime);
        TreegActive = false;
    }
}