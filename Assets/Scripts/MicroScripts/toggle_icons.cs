using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle_icons : MonoBehaviour
{
    public GameObject Tasks, Shop, Farmers, Industry;

    public BoxCollider2D ToggleIconsCollider;

    bool onscreen = false;
    private Vector3 startPoint;
    private Vector3 endPoint;
    //private float startTime;

    void OnMouseOver() {
        //print(gameObject.name);
        if (Input.GetMouseButtonDown(0)) {
            onscreen = !onscreen;
            show();
            //print("togglescript: " + onscreen);
            

            //Tasks.SetActive(!Tasks.activeInHierarchy);
            //Shop.SetActive(!Shop.activeInHierarchy);
            //Farmers.SetActive(!Farmers.activeInHierarchy);
            //Industry.SetActive(!Industry.activeInHierarchy);
            //Tasks.transform.position.x = -100;
            //Tasks.transform.position = Vector3.Lerp(startPoint, endPoint, (Time.deltaTime));
            //started = true;
            //startPoint = transform.position;
            //endPoint = new Vector3(500,400,0);
        }

        //by default the icons are off screen

        //when i click on the island, the 4 icons appear into view
        
        //when clicked, it should show the icon clicked on, but hide the rest (not setactive false!)
        //either turn off colliders and set icons to invisible or move icons out of view
    }

    void show() {
        if(onscreen) {
            
            //AppleTree.fruit;
        
            Tasks.transform.localPosition = new Vector3(280,400,0);
            Shop.transform.localPosition = new Vector3(280,220,0);
            Farmers.transform.localPosition = new Vector3(280,40,0);
            Industry.transform.localPosition = new Vector3(280,-140,0);
        }
        else {
            
            Tasks.transform.localPosition = new Vector3 (500,400,0);
            Shop.transform.localPosition = new Vector3 (500,220,0);
            Farmers.transform.localPosition = new Vector3 (500,40,0);
            Industry.transform.localPosition = new Vector3 (500,-140,0);
        }
    }
}