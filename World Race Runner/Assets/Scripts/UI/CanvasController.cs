using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    

    [SerializeField] private Sprite healtyHeart1,
        deadHeart1,
        healtyHeart2,
        deadHeart2,
        healtyHeart3,
        deadHeart3;

    [SerializeField] private Image healhMeter1,healhMeter2,healhMeter3;

    [SerializeField] private PlayerMovement playerMovement;
    
    
    // Traer al player
    // Player.CurrentHealh - 100 un corazon va a estar negro
    // 2 corazones vana  estar negros
    // 0 3 corzones negro  = perdimos
    
    private void Awake()
    { 
        /*var playerMovement =  GetComponent<PlayerMovement>();*/
        playerMovement.currentHealth = playerMovement.maxHealth;
    }

    private void Update()
    {
        UpdateLife(playerMovement.currentHealth);

    }

    private void UpdateLife(int currentLife)
    {
        var isHealthy1 = playerMovement.currentHealth >= playerMovement.maxHealth;
        healhMeter1.sprite = isHealthy1 ? healtyHeart1 : deadHeart1;
        
        
        var isHealthy2 = playerMovement.currentHealth >= playerMovement.maxHealth - 99 ;
        healhMeter2.sprite = isHealthy2 ? healtyHeart2 : deadHeart2;
        
        
        var isHealthy3 = playerMovement.currentHealth >= playerMovement.maxHealth - 149;
        healhMeter3.sprite = isHealthy3 ? healtyHeart3 : deadHeart3;
        
        
    }
    
    
    
}