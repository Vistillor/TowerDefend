using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mepegue : MonoBehaviour
{
    public int maxHelth = 100;
    public int currentHealth;

    public HealhBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHelth;
        healthBar.SetMaxHealth(maxHelth);
    }

    public void OnCollisionEnter(Collision collision)
    {
        TakeDamage(10);
    }

    // Update is called once per frame

    void TakeDamage(int damage)
    {

        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

}
