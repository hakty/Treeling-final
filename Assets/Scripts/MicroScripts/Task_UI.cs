using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task_UI : MonoBehaviour
{
    public BoxCollider2D[] island_col;
    public GameObject ui_element;
    //toggle UI element on/off

    public GameObject Tasks, Shop, Farmers, Industry, Inventory, e8, e9, e10;
    public Image render;
    public Image render2;
    public Text renderTxt;
    public static bool uiHidden = true;

    //public Text RCText;
    // public Text TotalRCText;
    // private float coins;
    //private float TotalCoins;

    void Start()
    {
        render = e8.GetComponent<Image>();
        render2 = e9.GetComponent<Image>();
        renderTxt = e10.GetComponent<Text>();
        hide();
    }

    void Update() {

       // coins = RCText.GetComponent<CoinText>().currentCoins;
        //TotalCoins = coins;
        //TotalRCText.text = "Total ReapCoins earned from fruit: " + GetComponent<SellFruit>().appleSell;

    }
    void SetInActive() {
        for(int i = 0; i < island_col.Length; i++) {
            island_col[i].enabled = false;
       }
        render.enabled = false;
        render2.enabled = false;
        renderTxt.enabled = false;
        //Tasks.transform.localPosition = new Vector3(280,400,0);
        //hide();
    }
    void SetActive() {
        for(int i = 0; i < island_col.Length; i++) {
            island_col[i].enabled = true;
       }
        render.enabled = true;
        render2.enabled = true;
        renderTxt.enabled = true;
        //show();
    }
    public void OnMouseDown() {
        //print(gameObject.name);
        if (Input.GetMouseButtonDown(0)) {
            //ui_element.SetActive(!ui_element.activeInHierarchy);
            //hide();
            //show();
            uiHidden = !uiHidden;
            
            if(uiHidden) {
                ui_element.transform.localPosition = new Vector3(0,4000,0);
                
            } else {
                ui_element.transform.localPosition = new Vector3(0,0,0);
            }
        }
        //if(ui_element.activeInHierarchy) {
        if(uiHidden == false) {
            //print("hit box off");
            SetInActive();
            hide();
        } else {
            //print("hitbox on");
            SetActive();
            //Inventory.transform.localPosition = new Vector3 (-280,580,0);
            //Tasks.transform.localPosition = new Vector3 (500,400,0);
            show();
        }     
    }
    void hide() {
        //Tasks.transform.localPosition = new Vector3 (500,400,0);
        Shop.transform.localPosition = new Vector3 (500,220,0);
        Farmers.transform.localPosition = new Vector3 (500,40,0);
        Industry.transform.localPosition = new Vector3 (500,-140,0);
        Inventory.transform.localPosition = new Vector3 (500,580,0);
    }
    void show() {
        //coin UI
        render.enabled = true;
        render2.enabled = true;
        renderTxt.enabled = true;

        Tasks.transform.localPosition = new Vector3(280,400,0);
        Shop.transform.localPosition = new Vector3(280,220,0);
        Farmers.transform.localPosition = new Vector3(280,40,0);
        Industry.transform.localPosition = new Vector3(280,-140,0);
        Inventory.transform.localPosition = new Vector3 (-280,580,0);
    }
}