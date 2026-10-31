using System;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    public int health;
    public int maxHealth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth; 
        slider.maxValue = maxHealth;
        slider.value = health;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        slider.value = health;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
