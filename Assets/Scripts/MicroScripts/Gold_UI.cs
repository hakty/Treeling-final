using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold_UI : MonoBehaviour
{
public BoxCollider2D island_col;
    
    public GameObject ui_element;
    //toggle UI element on/off

    public GameObject e1_task, e2_shop, e3_farmers, e4_industry, e5_warning;
     //toggle everything else off when ui_element is active

     void SetInActive() {
         island_col.enabled = false;
     }
     void SetActive() {
         island_col.enabled = true;
     }

    public void OnMouseOver() {
        //print(gameObject.name);
        if (Input.GetMouseButtonDown(0)) {
            ui_element.SetActive(!ui_element.activeInHierarchy);
            e1_task.SetActive(!e1_task.activeInHierarchy);
            e2_shop.SetActive(!e2_shop.activeInHierarchy);
            e3_farmers.SetActive(!e3_farmers.activeInHierarchy);
            e4_industry.SetActive(!e4_industry.activeInHierarchy);
            //e5_warning.SetActive(!e5_warning.activeInHierarchy);
            //e6.SetActive(!e6.activeInHierarchy);
        }

        //if(gameObject.tag == "island" && e1_task.activeInHierarchy) {
        //   GetComponent<Collider2D>().enabled = false;
        //   print("Island Hitbox off");
        //}
        if(ui_element.activeInHierarchy) {
            //print("hit box off");
            SetInActive();
            
        } else {
            //print("hitbox on");
            SetActive();
        }

        if (Input.GetMouseButtonDown(0) && e1_task.activeInHierarchy) {
            e1_task.SetActive(e1_task.activeInHierarchy == false);
        }
        if (Input.GetMouseButtonDown(0) && e2_shop.activeInHierarchy) {
            e2_shop.SetActive(e2_shop.activeInHierarchy == false);
        }
        if (Input.GetMouseButtonDown(0) && e3_farmers.activeInHierarchy) {
            e3_farmers.SetActive(e3_farmers.activeInHierarchy == false);
        }
        if (Input.GetMouseButtonDown(0) && e4_industry.activeInHierarchy) {
            e4_industry.SetActive(e4_industry.activeInHierarchy == false);
        }
    }
}
