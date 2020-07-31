using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public PlayerHealth target;
    public float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void EnemyHitEvent()
    {
        if (target == null) return;
        target.TakeDamage(damage);
        Debug.Log("bang bang");
    }
}
