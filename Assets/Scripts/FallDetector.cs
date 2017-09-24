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
    public bool Respawning; // Tracks whether the player is currently respawning.

    void Update()
    {
        if (Player.transform.position.y < MinDeathHeight && !Respawning)
        {
            Respawning = true;
            DeathSound.Play();
            StartCoroutine(MoveToSpawnPoint());
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
