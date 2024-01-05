using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;

    public void ChangeHealth(int value)
    {
        health += value;

        if (health <= 0)
            print("Yandin");
    }
}
