using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject theSword;
    public int swordStatus;
       
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && swordStatus == 0)
        {
            StartCoroutine(SwingSwordFn()); 
        }
    }

    IEnumerator SwingSwordFn()
    {
        swordStatus = 1;
        theSword.GetComponent<Animation>().Play("ElvenSwordAnim");
        swordStatus = 2;
        yield return new WaitForSeconds(1.0f);
        swordStatus = 0;
    }
}
