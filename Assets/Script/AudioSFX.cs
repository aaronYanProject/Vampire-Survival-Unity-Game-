using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverClip;
    [SerializeField] private AudioClip magicMissileLaunchClip;
    [SerializeField] private AudioClip takeDamageClip;

    public void PlayerGameOver()
    {
        audioSource.PlayOneShot(gameOverClip);
    }
    public void PlayMagicMissileLaunch()
    {
        audioSource.PlayOneShot(magicMissileLaunchClip);
    }
    public void PlayTakenDamage()
    {
        audioSource.PlayOneShot(takeDamageClip);
    }

}
