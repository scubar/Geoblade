using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour
{
    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject ThisHeart;

	void Update ()
	{
	    transform.Rotate(0, RotateSpeed, 0, Space.World);
	}


    void OnTriggerEnter()
    {
        CollectSound.Play();
        HealthMonitor.HealthValue++;
        ThisHeart.SetActive(false);
    }
}
