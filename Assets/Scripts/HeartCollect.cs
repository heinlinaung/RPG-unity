using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int rotateSpeed;
    public AudioSource collectSound;
    public GameObject thisHeart;

    void Update()
    {
        rotateSpeed = 2;
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        HeartMonitor.healthValue += 1;
        thisHeart.SetActive(false);
    }
}
