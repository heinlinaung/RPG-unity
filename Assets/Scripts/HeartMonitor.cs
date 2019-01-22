using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMonitor : MonoBehaviour
{
    public static int healthValue;
    public int internalHealth;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Start is called before the first frame update
    void Start()
    {
        healthValue = 1;
    }

    // Update is called once per frame
    void Update()
    {
        internalHealth = healthValue;
        if(healthValue == 1)
        {
            heart1.SetActive(true);
        }
        if (healthValue == 2)
        {
            heart2.SetActive(true);
        }
        if (healthValue == 3)
        {
            heart3.SetActive(true);
        }
    }
}
