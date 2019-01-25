using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective03 : MonoBehaviour
{
    public float theDistance;
    public GameObject sword_Chest;
    public GameObject sword_Player;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theObjective;
    public int closeObjective;
    public GameObject checkBlock;
    public GameObject quest001Complete;
    public GameObject questExMark;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
        if (closeObjective == 2)
        {
            if (theObjective.transform.localScale.y <= 0.0f)
            {
                closeObjective = 0;
                theObjective.SetActive(false);
            }
            else
            {
                theObjective.transform.localScale -= new Vector3(0, 0.01f, 0);
            }
        }
    }

    void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            Debug.Log("hello?");
            actionText.GetComponent<Text>().text = "Take the sword";
            actionText.SetActive(true);
            actionDisplay.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 2)
            {
                checkBlock.SetActive(true);
                this.GetComponent<BoxCollider>().enabled = false;
                sword_Chest.SetActive(false);
                sword_Player.SetActive(true);
                closeObjective = 2;
                actionText.SetActive(false);
                actionDisplay.SetActive(false);
                questExMark.SetActive(true);
                quest001Complete.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        actionText.SetActive(false);
        actionDisplay.SetActive(false);
    }
}
