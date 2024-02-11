using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character
{
    string characterName;
    int level;
    string classSelection;
    bool isHillDwarf;
    bool hasToughFeat;

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


    public Character()
    {
        characterName = "Christian";
    }

    public Character(string characterName, int level, string classSelection, bool isHillDwarf, bool hasToughFeat)
    {
        this.characterName = characterName;
        this.level = level;
        this.classSelection = classSelection;
        ClassCheck(classSelection);
        this.isHillDwarf = isHillDwarf;
        this.hasToughFeat = hasToughFeat;

    }

   public int ClassCheck(string className)
    {
        string classToUpperCase = char.ToUpper(classSelection[0]) + classSelection.Substring(1);

        return classDictionary[classSelection];


    }


   public void Print()
    {
        Debug.LogFormat(ClassCheck(classSelection));
    }

}
