using System.Collections.Generic;
using UnityEngine;

public enum ColorState
{
    Blue,
    Red,
    Green
}

public class PointArea : MonoBehaviour
{
    [SerializeField] private int pointsMateBlue = 100;
    [SerializeField] private int pointsMateRed = 200;
    [SerializeField] private int pointsMateGreen = 300;
    [SerializeField] private ColorState colorMate;
    private GameManager _gameManager;


    private void OnTriggerEnter(Collider other)
    {
        {
            AddPoints();
        }
    }
    private void Awake()
    {
        _gameManager = GameManager.instance;
        
    }

    private void AddPoints()
    {
        switch (colorMate)
        {
            case ColorState.Green:
                _gameManager.UpdatePoints(pointsMateGreen);
                break;

            case ColorState.Red:
                _gameManager.UpdatePoints(pointsMateRed);
                break;

            case ColorState.Blue:
                _gameManager.UpdatePoints(pointsMateBlue);
                break;
        }
        Destroy(gameObject, 0.5f);
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