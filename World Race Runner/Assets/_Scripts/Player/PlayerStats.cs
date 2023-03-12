using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] public int maxHealth;
    [SerializeField] public int currentHealth;
   

    private void Update()
    {
        if (currentHealth <= 0)
        {
            SceneLoseGame();
        }
    }

    public void RemoveLife(int p_damage)
    {
        currentHealth -= p_damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }
    
    public void SceneLoseGame()
    {
        SceneManager.LoadScene("Lose");
        Debug.Log("Recived OnSceneLoseGame, from GenericController, to GenericModel");
    }
}
