using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001 : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject uiQuest;
    public GameObject thePlayer;
    public GameObject noticeCam;
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
        }
        if (theDistance > 3)
        {
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3)
            {
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                uiQuest.SetActive(true);
                noticeCam.SetActive(true);
                thePlayer.SetActive(false);
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (theDistance <= 3)
            {
                actionDisplay.SetActive(true);
                actionText.SetActive(true);
                uiQuest.SetActive(false);
                noticeCam.SetActive(false);
                thePlayer.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
