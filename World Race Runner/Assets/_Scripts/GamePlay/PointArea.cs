using System;
using System.Collections.Generic;
using UnityEngine;

public enum ColorState
{
    Normal = 10,
    Red = 20,
    Green = 30
}



public class PointArea : MonoBehaviour
{
    [SerializeField] private Enum StateColor;
    
    public int pointsMateNormal = 10;
    public int pointsMateRed = 20;
    public int pointsMateGreen = 30;
    
     private int totalPoints = 0;

     
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddPoints();
            Destroy(gameObject, 0.2f);
        }
    }

    private void AddPoints()
    {
        switch (StateColor)
        {
            case ColorState.Green:
                totalPoints += 30;
                break;

            case ColorState.Red:
                totalPoints += 20;
                break;

            case ColorState.Normal:
                totalPoints += 10;
                break;
        }
            
    }
    

 

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    private void AddSkills()
    {
        Dictionary<string, int> skill = new Dictionary<string, int>();
        skill.Add("modeGod", 10);
        skill.Add("maxSpeed", 8);

        int value = skill["modeGod"];

        if (skill.ContainsKey("maxSpeed"))
        {
            Debug.Log("La clave existe");
        }

        foreach (KeyValuePair<string, int> element in skill)
        {
            Debug.Log("Clave: " + element.Key + "Valor: " + element.Value);
        }
        // Saber cuantos Mates Verdes se consumio el personaje y si tiene + de 10 mates verdes, posibilidad de usar
        //el skill de inmortal con la letra "F"

        // Saber cuantos Mates Verdes se consumio el personaje y si tiene + de 8 mates rojos, posibilidad de usar
        //el skill de maxSpeed con la letra "G"
    }
}