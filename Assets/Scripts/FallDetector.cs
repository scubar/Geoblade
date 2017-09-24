using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FallDetector : MonoBehaviour
{
    public Transform SpawnPoint;
    public float MinDeathHeight;
    public GameObject Player;
    public AudioSource DeathSound;
    public AudioSource DeathSound2;
    public bool Respawning; // Tracks whether the player is currently respawning.

    void Update()
    {
        if (Player.transform.position.y < MinDeathHeight && !Respawning)
        {
            Respawning = true;
            PlayDeathSound();
            StartCoroutine(MoveToSpawnPoint());
        }
    }

    void PlayDeathSound()
    {
        var rand = new System.Random();
        int num = rand.Next(1,2);

        switch (num)
        {
            case 1:
            {
                DeathSound.Play();
                break;
            }
            case 2:
            {
                DeathSound2.Play();
                break;
            }
        }

    }

    IEnumerator MoveToSpawnPoint()
    {
        yield return new WaitForSeconds(1);
        HealthMonitor.HealthValue = 0;
        Player.transform.position = SpawnPoint.position;
        Respawning = false;
    }
}
