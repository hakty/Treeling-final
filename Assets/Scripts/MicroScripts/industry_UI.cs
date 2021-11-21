using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class industry_UI : MonoBehaviour
{
    public BoxCollider2D[] island_col;
    public GameObject ui_element;
    //toggle UI element on/off
    public GameObject Tasks, Shop, Farmers, Industry, Inventory, e7, e8, e9;
    public Image render;
    public Image render2;
    public Text renderTxt;
    public static bool uiHidden = true;
    void Start(){
        render = e7.GetComponent<Image>();
        render2 = e8.GetComponent<Image>();
        renderTxt = e9.GetComponent<Text>();

        render.enabled = true;
        render2.enabled = true;
        renderTxt.enabled = true;
        hide();
    }
    void SetInActive() {
        for(int i = 0; i < island_col.Length; i++) {
            island_col[i].enabled = false;
       }
        render.enabled = false;
        render2.enabled = false;
        renderTxt.enabled = false;
        //Industry.transform.localPosition = new Vector3(280,-140,0);
     }
    void SetActive() {
        for(int i = 0; i < island_col.Length; i++) {
            island_col[i].enabled = true;
       }
        render.enabled = true;
        render2.enabled = true;
        renderTxt.enabled = true;
    }
    public void OnMouseDown() {
        //print(gameObject.name);
        if (Input.GetMouseButtonDown(0)) {
            //ui_element.SetActive(!ui_element.activeInHierarchy);
            //hide();
            //Inventory.transform.localPosition = new Vector3 (500,580,0);
            uiHidden = !uiHidden;

            if(uiHidden) {
                ui_element.transform.localPosition = new Vector3(-1000,2500,0);
            } else {
                ui_element.transform.localPosition = new Vector3(0,0,0);
            }
        }
        if(uiHidden == false) {
            //print("hit box off");
            SetInActive();
            hide();
        } else {
            //print("hitbox on");
            SetActive();
            //Inventory.transform.localPosition = new Vector3 (-280,580,0);
            //Industry.transform.localPosition = new Vector3 (500,-140,0);
            show();
        }
    }
    void hide() {
        Tasks.transform.localPosition = new Vector3 (500,400,0);
        Shop.transform.localPosition = new Vector3 (500,220,0);
        Farmers.transform.localPosition = new Vector3 (500,40,0);
        //Industry.transform.localPosition = new Vector3 (500,-140,0);
        Inventory.transform.localPosition = new Vector3 (500,580,0);
    }
    void show() {
        Tasks.transform.localPosition = new Vector3(280,400,0);
        Shop.transform.localPosition = new Vector3(280,220,0);
        Farmers.transform.localPosition = new Vector3(280,40,0);
        Industry.transform.localPosition = new Vector3(280,-140,0);
        Inventory.transform.localPosition = new Vector3 (-280,580,0);
    }   
}
