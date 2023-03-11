using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] public int maxHealth;
    [SerializeField] public int currentHealth;


    public void RemoveLife(int p_damage)
    {
        currentHealth -= p_damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

    }
}
