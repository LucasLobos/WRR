using System.Collections.Generic;
using UnityEngine;

public enum ColorState
{
    Normal,
    Red,
    Green
}

public class PointArea : MonoBehaviour
{
    [SerializeField] private ColorState currentColor;

    private int _points = 0;
    /*
    private int _totalPoints = 0;
    */


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            /*GameManager manager = GameManager.instance;
            manager.AddPoints();*/
            AddSkills();
            AddPoints();
            Destroy(gameObject, 0.2f);
        }
    }
    
    private void AddPoints()
    {
        switch (currentColor)
        {
            case ColorState.Green:
                _points += 3;
                break;

            case ColorState.Red:
                _points += 2;
                break;

            case ColorState.Normal:
                _points += 1;
                break;
        }

        Debug.Log($"Contando puntos {_points}");
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

        foreach (KeyValuePair<string,int> element in skill)
        {
            Debug.Log("Clave: " + element.Key + "Valor: " + element.Value);
        }
        // Saber cuantos Mates Verdes se consumio el personaje y si tiene + de 10 mates verdes, posibilidad de usar
        //el skill de inmortal con la letra "F"

        // Saber cuantos Mates Verdes se consumio el personaje y si tiene + de 8 mates rojos, posibilidad de usar
        //el skill de maxSpeed con la letra "G"
    }
}