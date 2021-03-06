﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SkillsDB
{
    // Data
    public Dictionary<string, Skill> skills;

    // Singleton
    protected static SkillsDB instance;

    // Constructor
    protected SkillsDB()
    {
        // Initializing structures
        skills = new Dictionary<string, Skill>();
        // Creating example database
        createExampleDatabase();
    }

    // Properties    
    public static SkillsDB Instance
    {
        get
        {
            return instance == null ? instance = new SkillsDB() : instance;
        }
    }

    // Methods
    private void createExampleDatabase()
    // Creates an Example Database for testing purpouses. Typically called from constructor. It follows
    // the way an user would create things from editor.
    {
        Debug.Log("Creating Skill database!");
        // Filling core core 'attributes' (exist in every RPG)
        /*
        Skill skill1 = new Skill("Bola de fuego", "Lanza una bola de fuego a un enemigo", "Unitarget", 200, 2);
        Skill skill2 = new Skill("Bola de hielo", "Lanza una bola de fuego a un enemigo", "Unitarget", 200, 2);
        Skill skill3 = new Skill("Cura", "cura a un aliado", "Unitarget", 200, 3);
        skills.Remove("Bola de fuego");
        skills.Remove("Bola de hielo");
        skills.Remove("Cura");
        */


        Debug.Log("Database created!");
    }

    public List<string> getAttribIdentifiers()
    {
        List<string> attribIdentifiers = new List<string>();
        //foreach (KeyValuePair<string, Attribute> result in attributes)
        //{
          //  attribIdentifiers.Add(result.Value.label);
        //}
        return attribIdentifiers;
        //return attribIdentifiers.Count==0 ? null : attribIdentifiers;
    }

    public void loadDatabase()
    // Retrieves the database from file to continue filling it. This file was (obviously) previously 
    // saved by the user when he was editing from Editor
    {
        // AssetDatabase.FindAssets("t:Mitipo");
    }

    public bool addTemplate()
    // Adds a Template (SpecTemplate, ItemTemplate, PassiveTemplate) to the database. The idea
    // is that this method will be called from Editor when you CREATE a Spec, Item or Passive
    {
        // TO DO
        return true;
    }

    public bool deleteTemplate()
    {
        // Deletes a Template (SpecTemplate, ItemTemplate, PassiveTemplate) from the database. The idea
        // is that this method will be called from Editor when you DELETE a Spec, Item or Passive
        // TO DO
        return false;
    }

    public void modifyTemplate()
    // Modifies a Template (SpecTemplate, ItemTemplate, PassiveTemplate) in the database. The idea
    // is that this method will be called from Editor when you EDIT a Spec, Item or Passive
    {
    }

    public bool addSkill(Skill skill)
    // Adds a new Attribute to the database. Since every character in the game will need these
    // we can specify some as 'core' attributes which everyone will have. Attributes which are no
    // 'core' may be limited to certain kind of characters (Spec attached) or simply derived attributes
    // that everyone can posess but may never use
    {
        
        bool canAdd = skills.ContainsValue(skill) ? false : true;
        if (canAdd)
            skills.Add(skill.getName(), skill);
        return canAdd;

    }


    public bool deleteSkill(Skill skill)
    {
        bool canDelete = skills.ContainsValue(skill) ? true: false;
        if (canDelete)
            skills.Remove(skill.getName());
        return canDelete;
    }
    public bool deleteAttribute(string atr)
    // Delete an existing Attribute from the database if this attribute exist. KEEP IN MIND that deleting an attribute
    // COULD cause problems if it has dependencies 
    {
        /*
        bool canDelete = attributes.ContainsKey(atr) ? true : false;
        if (canDelete)
            attributes.Remove(atr);
            */
        return false;
    }

    public Skill[] getSavedSkills()
    {
        Skill[] array = new Skill[skills.Count];
        skills.Values.CopyTo(array, 0);

        return array;
    }

    public bool updateSkill(Skill skill)
    {
        bool canDelete = skills.ContainsValue(skill) ? true : false;
        skills[skill.getName()] = skill;
        return canDelete;
    }

    public void print()
    {
        Debug.Log("I'm a database");
    }

}