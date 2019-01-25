using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Btn : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject noticeCam;
    public GameObject uiQuest;
    public GameObject activeQuestBox;
    public GameObject objective01;
    public GameObject objective02;
    public GameObject objective03;
    public GameObject questExMark;
    public GameObject questNoticeBoard;
    public GameObject questNoticeTrigger;

    public void AcceptQuest() {
        thePlayer.SetActive(true);
        noticeCam.SetActive(false);
        uiQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
    }

    IEnumerator SetQuestUI()
    {
        questExMark.SetActive(false);
        questNoticeBoard.SetActive(false);
        questNoticeTrigger.SetActive(false);
        activeQuestBox.GetComponent<Text>().text = "First Weapon";
        objective01.GetComponent<Text>().text = "Reach the clearing in the wood";
        objective02.GetComponent<Text>().text = "Open the chest";
        objective03.GetComponent<Text>().text = "Retrieve the weapon";
        QuestManager.activeQuestNumber = 1;
        yield return new WaitForSeconds(0.5f);
        activeQuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        objective01.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        objective02.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        objective03.SetActive(true);
        yield return new WaitForSeconds(7);
        activeQuestBox.SetActive(false);
        objective01.SetActive(false);
        objective02.SetActive(false);
        objective03.SetActive(false);
    }
    public void DeclineQuest() 
    {
        thePlayer.SetActive(true);
        noticeCam.SetActive(false);
        uiQuest.SetActive(false);
    }
}
