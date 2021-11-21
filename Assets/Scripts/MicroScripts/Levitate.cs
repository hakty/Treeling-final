using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitate : MonoBehaviour
{
    Vector3 posOffset = new Vector3 ();
    Vector3 posOffset2 = new Vector3 ();
    Vector3 posOffset3 = new Vector3 ();
    Vector3 posOffset4 = new Vector3 ();
    Vector3 posOffset5 = new Vector3 ();
    Vector3 posOffset6 = new Vector3 ();


    Vector3 tempPos = new Vector3 ();
    Vector3 tempPos2 = new Vector3 ();
    Vector3 tempPos3 = new Vector3 ();
    Vector3 tempPos4 = new Vector3 ();
    Vector3 tempPos5 = new Vector3 ();
    Vector3 tempPos6 = new Vector3 ();
   
    public float amplitude = 0.5f;
    public float frequency = 0.5f;
    public GameObject islandObject1,islandObject2,islandObject3,islandObject4,islandObject5,islandObject6;

    public GameObject AppleUi,BananaUi,OrangeUi,LemonUi,CoconutUi,CocoaUi;
    //total of 6 islands 0>1>2>3>4>5
    private int currentIsland = 0;
    //private float islandDistance = 6;
    void Start()
    {
        posOffset = transform.position;
        posOffset2 = transform.position;
        posOffset3 = transform.position;
        posOffset4 = transform.position;
        posOffset5 = transform.position;
        posOffset6 = transform.position;
    }
    void Update()
    {
       
       if(currentIsland != 0) AppleUi.SetActive(false);
       else AppleUi.SetActive(true);

       if(currentIsland != 1) BananaUi.SetActive(false);
       else BananaUi.SetActive(true);

       if(currentIsland != 2) OrangeUi.SetActive(false);
       else OrangeUi.SetActive(true);

       if(currentIsland != 3) LemonUi.SetActive(false);
       else LemonUi.SetActive(true);   

       if(currentIsland != 4) CoconutUi.SetActive(false);
       else CoconutUi.SetActive(true);   

       if(currentIsland != 5) CocoaUi.SetActive(false);
       else CocoaUi.SetActive(true);          
       
        Swipe();
    


       if(currentIsland == 0){
        //AppleUi.SetActive(AppleUi.activeInHierarchy);
        
        //islandObject1
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        tempPos.x = transform.position.x;
        islandObject1.transform.position = tempPos;
        islandObject1.transform.localPosition = new Vector3(-262,-618,0);
       }
       if(currentIsland == 1) {
        tempPos2 = posOffset2;
        tempPos2.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        tempPos2.x = transform.position.x;
        islandObject2.transform.position = tempPos2;
        islandObject2.transform.localPosition = new Vector3(-262,-618,0); //apple tree
       }
       if(currentIsland == 2) {
        tempPos3 = posOffset3;
        tempPos3.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        tempPos3.x = transform.position.x;
        islandObject3.transform.position = tempPos3;
        islandObject3.transform.localPosition = new Vector3(-262,-618,0); //apple tree
       }
       if(currentIsland == 3) {
        tempPos4 = posOffset4;
        tempPos4.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        tempPos4.x = transform.position.x;
        islandObject4.transform.position = tempPos4;
        islandObject4.transform.localPosition = new Vector3(-262,-618,0);
       }
       if(currentIsland == 4) {
        tempPos5 = posOffset5;
        tempPos5.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        tempPos5.x = transform.position.x;
        islandObject5.transform.position = tempPos5;
        islandObject5.transform.localPosition = new Vector3(-262,-618,0);
       }
        if(currentIsland == 5) {
        tempPos6 = posOffset6;
        tempPos6.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        tempPos6.x = transform.position.x;
        islandObject6.transform.position = tempPos6;
        islandObject6.transform.localPosition = new Vector3(-262,-618,0);
       } 
    }

    void Swipe() {
        //starting island1 -> island2 -> island3
        if(NextIsland.swipeLeft) {
            //print("swipe right" + currentIsland);
            currentIsland++;
            if(currentIsland == 6)
            currentIsland = 5;
        }
        if(NextIsland.swipeRight) {
            //print("swipe left" + currentIsland);
            currentIsland--;
            if(currentIsland == -1)
            currentIsland = 0;
        }
        //Vector3 newPosition = transform.position.x * transform.right; //?

        if(currentIsland == 0) {
            //newPosition += Vector3.left * islandDistance;
            //print("island 1");
            
            islandObject1.transform.localPosition = new Vector3(-262,-618,0); //apple

            islandObject2.transform.localPosition = new Vector3(500,-618,0);
            islandObject3.transform.localPosition = new Vector3(800,-618,0);
            islandObject4.transform.localPosition = new Vector3(1200,-618,0);
            islandObject5.transform.localPosition = new Vector3(1600,-618,0);
            islandObject6.transform.localPosition = new Vector3(2000,-618,0);
           // tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
            //transform.position = tempPos;

        } 
        if(currentIsland == 1){
            //print("island2");
            islandObject2.transform.localPosition = new Vector3(-262,-618,0); //banana

            islandObject1.transform.localPosition = new Vector3(-1000,-618,0);
            islandObject3.transform.localPosition = new Vector3(500,-618,0);
            islandObject4.transform.localPosition = new Vector3(800,-618,0);
            islandObject5.transform.localPosition = new Vector3(1200,-618,0);
            islandObject6.transform.localPosition = new Vector3(1600,-618,0);
           // tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
            //transform.localPosition = Vector2.Lerp(transform.localPosition,targetPosition, 10f * Time.fixedDeltaTime);
            //transform.position = tempPos;
        }
        if(currentIsland == 2){
            //print("island3");
            islandObject3.transform.localPosition = new Vector3(-262,-618,0);

            islandObject1.transform.localPosition = new Vector3(-1300,-618,0);
            islandObject2.transform.localPosition = new Vector3(-1000,-618,0);
            
            islandObject4.transform.localPosition = new Vector3(500,-618,0);
            islandObject5.transform.localPosition = new Vector3(800,-618,0);
            islandObject6.transform.localPosition = new Vector3(1200,-618,0);
            //tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        }
        if(currentIsland == 3){
            //print("island4");
            islandObject1.transform.localPosition = new Vector3(-1600,-618,0);
            islandObject2.transform.localPosition = new Vector3(-1300,-618,0);
            islandObject3.transform.localPosition = new Vector3(-1000,-618,0);
            islandObject4.transform.localPosition = new Vector3(-262,-618,0);
            islandObject5.transform.localPosition = new Vector3(500,-618,0);
            islandObject6.transform.localPosition = new Vector3(800,-618,0);
        }
        if(currentIsland == 4){
            //print("island5");

            islandObject1.transform.localPosition = new Vector3(-1900,-618,0);
            islandObject2.transform.localPosition = new Vector3(-1600,-618,0);
            islandObject3.transform.localPosition = new Vector3(-1300,-618,0);
            islandObject4.transform.localPosition = new Vector3(-1000,-618,0);
            islandObject5.transform.localPosition = new Vector3(-262,-618,0);
            islandObject6.transform.localPosition = new Vector3(500,-618,0);
        }
        if(currentIsland == 5){
            //print("island6");
            
            
            islandObject1.transform.localPosition = new Vector3(-2200,-618,0);
            islandObject2.transform.localPosition = new Vector3(-1900,-618,0);
            islandObject3.transform.localPosition = new Vector3(-1600,-618,0);
            islandObject4.transform.localPosition = new Vector3(-1300,-618,0);
            islandObject5.transform.localPosition = new Vector3(-1000,-618,0);
            islandObject6.transform.localPosition = new Vector3(-262,-618,0);
        }
        //transform.position = Vector3.Lerp(transform.position,newPosition, 10f * Time.fixedDeltaTime);
    }
}
