﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formula
    {
    public string label;  // Attribute 'label' that identifies which attribute do we modify
    public string formula;  // Formula as a string 'formula' that modifies the attribute identified by 'label'
    public int priority;  // When to apply the formula in relation to other formulas in the container they are in
    
    public Formula(string label, string formula, int priority)
        {
        this.label=label;
        this.formula=formula;
        this.priority=priority;
        }
    }

