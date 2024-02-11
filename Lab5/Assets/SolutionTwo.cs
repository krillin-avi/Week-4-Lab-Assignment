using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionTwo : MonoBehaviour
{
    public string characterName;
    public int level;
    public string classSelection;
    public int conScore;
    public bool isHillDwarf;
    public bool hasToughFeat;
    public bool averageDie;
    public bool rollDie;

    void Start()
    {
        
        
        NameWillChange nameWillChange = new NameWillChange();
        nameWillChange(characterName);




    }

    
}

public class NameWillChange 
{
   

    // Data Sets
    Dictionary<string, int> classDictionary = new Dictionary<string, int>
    {
        {"Artificer", 8},
        {"Barbarian", 12},
        {"Bard", 8},
        {"Cleric", 8},
        {"Druid", 8},
        {"Fighter", 10},
        {"Monk", 8},
        {"Ranger", 10},
        {"Rogue", 8},
        {"Paladin", 10},
        {"Sorcerer", 6},
        {"Wizard", 6},
        {"Warlock", 8}
    };

    NameWillChange(string name)
    { 
        
         this.characterName = name;
       
        //Debug.Log("My character " + characterName + " is a level " + level + " with a CON score of " + conScore + " and " + isHillDwarf + " a Hill Dwarf and" + hasToughFeat + "Tough feat. I want the HP" + averageDie);
        
    }

    void returnString()
    {
        return this.
    }

   
}
