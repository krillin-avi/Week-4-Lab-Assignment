using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Character
{
    // Global Variables
    string characterName;
    int level;
    string classSelection;
    bool isHillDwarf;
    bool hasToughFeat;
    int toughBonus;
    int dwarfBonus;

    int classHitDieValue;

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

    public Character(string characterName, int level, string classSelection, bool isHillDwarf, bool hasToughFeat)
    {
        this.characterName = characterName;
        this.level = level;
        this.classSelection = classSelection;
        this.isHillDwarf = isHillDwarf;
        this.hasToughFeat = hasToughFeat;
    }

    void ClassCheckedValue (string className)
    {
        string classToUpperCase = char.ToUpper(className[0]) + className.Substring(1);
        classHitDieValue = classDictionary[classToUpperCase];
    }

    int IsHillDwarf(bool isHillDwarf)
    {
        if (isHillDwarf)
        {
            return dwarfBonus = level++;
        }
        else
        {
            return dwarfBonus = 1;
        } 
    }

    int HasToughFeat(bool hasToughFeat)
    {
        if (hasToughFeat)
        {
            return toughBonus = 2;
        }
        else
        {
            return toughBonus = 1;
        }

    }

    // Getter Functions to Respect Encapsulation :)
    public string GetName()
    { return this.characterName; }

    public int GetLevel()
    { return this.level; }

    public string GetClassSelection()
    { return this.classSelection; }

    public int GetClassCheckedValue()
    { return classHitDieValue;  }

    public int GetDwarfBonus()
    { return this.dwarfBonus; }

    public int GetToughBonus()
    { return this.toughBonus; }


}
