using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Timers;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator creator;
    [SerializeField] private UnityEvent missileLaunch;
    private void LaunchMissle()
    {
        creator.CreateMissle();
        missileLaunch.Invoke();
    }

    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, 1, LaunchMissle);
    }
}
