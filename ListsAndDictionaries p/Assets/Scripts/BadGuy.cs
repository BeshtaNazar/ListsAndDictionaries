using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    //This method is required by the IComparable
    //interface. 
    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        //Return the difference in power.
        return power - other.power;
    }
}

