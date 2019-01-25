using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective02 : MonoBehaviour
{
    public float theDistance;
    public GameObject treasureChest;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theObjective;
    public int closeObjective;
    public GameObject takeSword;

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
        if(theDistance <= 3)
        {
            actionText.GetComponent<Text>().text = "Open Chest";
            actionText.SetActive(true);
            actionDisplay.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                treasureChest.GetComponent<Animation>().Play("Q01ChestOpen");
                takeSword.SetActive(true);
                closeObjective = 2;
                actionText.SetActive(false);
                actionDisplay.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionText.SetActive(false);
        actionDisplay.SetActive(false);
    }
}
