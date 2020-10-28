using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Target1 : MonoBehaviour
{
    public float Health = 100f;
    public float currentHealth;

    public Slider HealthBar;

    void Start()
    {
        currentHealth = Health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        HealthBar.value = currentHealth;

        if(currentHealth <= 0)
        {
            Die();
        }
    }
    
    public void Die()
    {
        SceneManager.LoadScene("Dead");
    }

}
