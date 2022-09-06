using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Health health;

    public void UpdateUI()
    {
        healthBar.value = health.value;
    }

    private void Awake()
    {
      healthBar.maxValue= health.value;
      healthBar.value= health.value;
    }
}
