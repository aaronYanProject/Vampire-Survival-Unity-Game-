using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCreator : MonoBehaviour
{
    [SerializeField] private GameObject missilePrefab;
    [SerializeField] private Transform PlayerTransform;
 public void CreateMissle()
    {
        Instantiate(missilePrefab, PlayerTransform.position, Quaternion.identity);
    }
}
