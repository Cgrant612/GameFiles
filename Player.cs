using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehavior
{

    private int experience; //denotes the field

    public int Experience //denotes the property related to the field
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000; //this sets it so that the player levels up after every 1000 experience points
        }
        set
        {
            experience = value * 1000;  //receives a level and calculates the amount of experience a player has
        }
    }

    public int Health { get; set; }
}