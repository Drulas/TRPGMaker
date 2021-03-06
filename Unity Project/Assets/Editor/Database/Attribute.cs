﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute
    {
    // Defined in editor
    public bool isCore;  // 'true' if is a core attribute
    public string id;  // Three letters identifier
    public string name;  // Long identifier
    public string description;
    public int maxValue;
    public int minValue;
    // Defined in game (now just default values)
    public int value;

    public Attribute(bool isCore, string id, string name, string description, int minValue, int maxValue)
        {
        // Defined in editor
        this.isCore=isCore;
        this.id=id;
        this.name=name;
        this.description=description;
        this.minValue=minValue;
        this.maxValue=maxValue;
        // Defined in game (now just defalut values)
        this.value=minValue;
        }

    public void print()
        {
        Debug.Log("I'm an attribute");
        }
    }
