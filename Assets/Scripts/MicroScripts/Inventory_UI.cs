using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_UI : MonoBehaviour
{
   public BoxCollider2D[] island_col;
    
    public GameObject ui_element;
    //toggle UI element on/off
    //bool onscreen = false;
    private Vector3 startPoint;
    private Vector3 endPoint;

    public static bool uiHidden = true;

    public GameObject Tasks, Shop, Farmers, Industry,Inventory, e6, e7, e8;
     //toggle everything else off when ui_element is active
    //Renderer rend = gameObject.GetComponent<Renderer>();
    public Image render;
    public Image render2;
    public Text renderTxt;

    void Start()
    {
        render = e6.GetComponent<Image>();
        render2 = e7.GetComponent<Image>();
        renderTxt = e8.GetComponent<Text>();

        render.enabled = true;
        render2.enabled = true;
        renderTxt.enabled = true;
        Inventory.transform.localPosition = new Vector3 (-280,580,0);
        //hide();
    }

     void SetInActive() {
        for(int i = 0; i < island_col.Length; i++) {
            island_col[i].enabled = false;
       }
       
     }
     void SetActive() {
        for(int i = 0; i < island_col.Length; i++) {
            island_col[i].enabled = true;
       }
     }

    public void OnMouseDown() {
        //print(gameObject.name);
        if (Input.GetMouseButtonDown(0)) {
            //ui_element.SetActive(!ui_element.activeInHierarchy);
            hide();
            uiHidden = !uiHidden;

            if(uiHidden) {
                ui_element.transform.localPosition = new Vector3(-1000,4000,0);
            } else {
                ui_element.transform.localPosition = new Vector3(0,0,0);
            }
            //print("invUIscript: " + onscreen);
        }

        //if(gameObject.tag == "island" && e1_task.activeInHierarchy) {
        //   GetComponent<Collider2D>().enabled = false;
        //   print("Island Hitbox off");
        //}
        if(uiHidden == false) {
            //print("hit box off");
            SetInActive();
            render.enabled = false;
            render2.enabled = false;
            renderTxt.enabled = false;        
        } else {
            //print("hitbox on");
            SetActive();
            render.enabled = true;
            render2.enabled = true;
            renderTxt.enabled = true;
        }
    }
    void hide() {
        //uiHidden = true;
        Tasks.transform.localPosition = new Vector3 (500,400,0);
        Shop.transform.localPosition = new Vector3 (500,220,0);
        Farmers.transform.localPosition = new Vector3 (500,40,0);
        Industry.transform.localPosition = new Vector3 (500,-140,0);
    }
    void show() {
        //uiHidden = false;
        Tasks.transform.localPosition = new Vector3(280,400,0);
        Shop.transform.localPosition = new Vector3(280,220,0);
        Farmers.transform.localPosition = new Vector3(280,40,0);
        Industry.transform.localPosition = new Vector3(280,-140,0);
    }
}