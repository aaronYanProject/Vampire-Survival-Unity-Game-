using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Timers;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent attack;
    private bool _canAttack=true;
    private void OnTriggerEnter2D(Collider2D col)
    {
      DealDamage(col);
    }
   
    private void OnTriggerStay2D(Collider2D other)
    {
       DealDamage(other);
    }
    private void CanAttack()
    {
        _canAttack = true;
    }
    private void DealDamage(Collider2D other) 
    {
        if (!_canAttack) return;
        if (other.CompareTag(targetTag))
            {

                var damageable = other.GetComponent<Damageable>();
                damageable.TakeDamage(1);
                TimersManager.SetTimer(this, 1, CanAttack);
                _canAttack = false;
            attack.Invoke();
            
        }
}
    }
