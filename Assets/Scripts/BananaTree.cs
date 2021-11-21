using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaTree : MonoBehaviour
{
    [SerializeField] private GameObject bananaGameObject, bananaTree1, bananaTree2, bananaTree3;
    [SerializeField] public BoxCollider2D fruit;

    bool stage1 = false;
    bool stage2 = false;
    public static bool stage3 = false;
    bool notPicked = true;
    private float RegrowFruitTimer = 60.0f;  
    private int addFruit;
    public Text fruitText;  
    public float inGameTime;
    public float TreeAge = 0;
    public Text treeAge,TreeType;
    void Start() 
    {
        treeAge.text = "" + TreeAge + " Day old";
        TreeType.text = "Banana Tree";
        InvokeRepeating("Timer", 1.0f, 1.0f);
        //Testing below
        //InvokeRepeating("Timer", 1.0f, 0.5f);

        bananaTree1.SetActive(false);
        bananaTree2.SetActive(false);
        bananaTree3.SetActive(false);
        
        if (PlayerPrefs.HasKey("BananaTree"))
        {
            TreeAge = PlayerPrefs.GetFloat("BananaTree");
        }
    }

    // Update is called once per frame
    void Update() {
        if (bananaGameObject == true) {
            inGameTime += Time.deltaTime;
            //print(inGameTime);
            grow();
        }
        if(Inventory_UI.uiHidden == false) fruit.enabled = false;
        if(Task_UI.uiHidden == false) fruit.enabled = false;
        if(Shop_UI.uiHidden == false) fruit.enabled = false;
        if(industry_UI.uiHidden == false) fruit.enabled = false;
        if(Farmer_UI.uiHidden == false) fruit.enabled = false;

        TreeAge += 0;
        PlayerPrefs.SetFloat("BananaTree", TreeAge);

    }
    void CollectFruit() {
        if(UseItem.FruitbActive) {
            addFruit = fruitText.GetComponent<TrackBananas>().banana += Random.Range(120,240);
        } else {
            addFruit = fruitText.GetComponent<TrackBananas>().banana += Random.Range(60,120);
        }
    
    }
    public void OnMouseDown() {
        //if (!Input.GetMouseButtonDown(0)) return;
        if(gameObject.name == "Banana"){
            CollectFruit();
            notPicked = false;
            stage3 = false;
            fruit.enabled = false;
            stage2 = true;
            StartCoroutine(growstage3()); 
        }
    }
    void grow() {
        //conditions to activate tree stages
        if(TreeAge < 3){
            stage1 = true;
        }
        if(TreeAge >= 10) {
            stage1 = false;
            stage2 = true;
        }
        if(TreeAge >= 20 && notPicked == true) {
            fruit.enabled = true;          
            stage2 = false;
            stage3 = true; 
        }
        //activates trees when conditions are met
        if (stage1) {
            fruit.enabled = false;
            bananaTree1.SetActive(true);
            bananaTree2.SetActive(false);
            bananaTree3.SetActive(false);
        }
        if (stage2) {
            fruit.enabled = false;
            bananaTree1.SetActive(false);
            bananaTree2.SetActive(true);
            bananaTree3.SetActive(false);
        }
        if (stage3) {
            fruit.enabled = true;
            bananaTree1.SetActive(false);
            bananaTree2.SetActive(false);
            bananaTree3.SetActive(true);
        }
    }
    IEnumerator growstage3() {
        yield return new WaitForSeconds(RegrowFruitTimer);
        notPicked = true;
        stage3 = true;
        stage2 = false;
        fruit.enabled = true; 
    }
    void Timer() {
        //10seconds = 1 day
        //5mins = 1month
        //30mins = 6months
        //1hour = 1year
        TreeAge++;
        if(TreeAge <= 30) {
            treeAge.text = "" + TreeAge + " Day old";
        }
        if(TreeAge >= 30) {
            treeAge.text = (TreeAge / 30.416).ToString("F1") + " Month old";
        }
        if(TreeAge >= 365) {
            treeAge.text = (TreeAge / 30.416 / 12).ToString("F1") + " Year old";
        }
        //Tree Death
        //if(TreeAge >= TreeDeath) {
        //    treeAge.text = "Reached <> Years, Tree has died";
        //}        
    }
}
