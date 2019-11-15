using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsAlt : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    void Start () {
        currentHealth = maxHealth;
    }

    void Update () {

    }

    public void TakeDamage () {

    }
}