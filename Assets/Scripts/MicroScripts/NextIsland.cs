using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextIsland : MonoBehaviour
{
    public static bool swipeLeft, swipeRight;
    private bool isDragging = false;
    private Vector2 startTouch, swipeDelta;


    void Update()
    {
        
    if(Inventory_UI.uiHidden && Shop_UI.uiHidden && industry_UI.uiHidden && Task_UI.uiHidden && Farmer_UI.uiHidden) {
        
        swipeLeft = swipeRight = false;

        #region Standalone Inputs
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            Reset();
        }
        #endregion

        #region Mobile Input
        if(Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isDragging = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDragging = false;
                Reset();
            }
        }
        #endregion
        
        //calculate the distance
        swipeDelta = Vector2.zero;
        if (isDragging)
        {
            if (Input.touches.Length < 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if (Input.GetMouseButton(0))
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
        }
        //Did we cross the distance?
        if (swipeDelta.magnitude > 30) //125
        {
            //which direction?
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                //Left or Right
                if (x < 0)
                    swipeLeft = true;
                else
                    swipeRight = true;
            }
            //else
            //{
                //Up or Down
                //if (y < 0)
                //    swipeDown = true;
                //else
                //    swipeUp = true;
            //}
            Reset();
        }
        /*
        if(swipeLeft) {
            //ui_element.transform.localPosition = new Vector3(-1000,2500,0);
            islandObject1.transform.localPosition = new Vector3(-262,-618,0);
            islandObject2.transform.localPosition = new Vector3(-1000,-618,0);
            print("swipeleft");
        }
        if(swipeRight) {
            print("swiperight");
            islandObject1.transform.localPosition = new Vector3(-1000,-618,0);
            islandObject2.transform.localPosition = new Vector3(-262,-618,0);
        }
        */

    }
    }

    private void Reset() 
    {
        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }
}
