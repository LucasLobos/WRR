using System;
using UnityEngine;

public class DisappearCar : MonoBehaviour
{
    [SerializeField] private GameObject car;
    [SerializeField] private float lifetime;


    private void Update()
    {
        TimeToDissapear();
    }

    private void TimeToDissapear()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            DissapearCar();
        }
    }

    private void DissapearCar()
    {
        Destroy(car);
    }
}




