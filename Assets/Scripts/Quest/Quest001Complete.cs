using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Complete : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject uiQuest;
    public GameObject thePlayer;
    public GameObject questExMark;
    public GameObject completeTrigger;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            actionText.GetComponent<Text>().text = "Complete Quest 001";
        }
        //if (theDistance > 3)
        //{
        //    actionDisplay.SetActive(false);
        //    actionText.SetActive(false);
        //}

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                //Screen.lockCursor = false;
                //Cursor.visible = true;
                questExMark.SetActive(false);
                GlobalExp.currentExp += 100;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                completeTrigger.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
