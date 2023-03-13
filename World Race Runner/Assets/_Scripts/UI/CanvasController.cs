using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private TMP_Text timeGame;
    [SerializeField] private TMP_Text scoreGame;
    [SerializeField] private Sprite healtyHeart1,
        deadHeart1;
        /*
        healtyHeart2,
        deadHeart2,
        healtyHeart3,
        deadHeart3;
        */
    
    [SerializeField] private Image healhMeter1/*,healhMeter2,healhMeter3*/;
    [SerializeField] private PlayerStats player;
    private float _elapsedTime = 0.0f;

    
    // Traer al player
    // Player.CurrentHealh - 100 un corazon va a estar negro
    // 2 corazones vana  estar negros
    // 0 3 corzones negro  = perdimos
    
    private void Awake()
    {
        var player = this.player.GetComponent<PlayerStats>();

        player.currentHealth = player.maxHealth;

    }

    private void Update()
    {
        UpdateLife(player.currentHealth);
        _elapsedTime += Time.deltaTime;
        UpdateTime();
    }

    private void UpdateLife(int currentLife)
    {
        var isHealthy1 = player.currentHealth >= player.maxHealth;
        healhMeter1.sprite = isHealthy1 ? healtyHeart1 : deadHeart1;
        
        /*
        var isHealthy2 = player.currentHealth >= player.maxHealth - 99 ;
        healhMeter2.sprite = isHealthy2 ? healtyHeart2 : deadHeart2;
        
        var isHealthy3 = player.currentHealth >= player.maxHealth - 149;
        healhMeter3.sprite = isHealthy3 ? healtyHeart3 : deadHeart3;*/
        
    }
    
    /*
    GetComponent<Text>().text = "Tiempo transcurrido: " + elapsedTime.ToString("0.00");
    */
    private void UpdateTime()
    {
        timeGame.text = "TIME : " + _elapsedTime.ToString("0.0");
    }
    
    
}