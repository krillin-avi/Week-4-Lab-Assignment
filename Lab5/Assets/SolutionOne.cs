using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

public class SolutionOne : MonoBehaviour
{
    // Player Data
    public string characterName;
    public int level;
    public string classSelection;
    public int conScore;
    public bool isHillDwarf;
    public bool hasToughFeat;
    public bool averageDie;
    public bool rollDie;
    
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

    Dictionary<int, int> abilityScoreModifiers = new Dictionary<int, int>
    {
        {1, -5},
        {2, -4},
        {3, -4},
        {4, -3},
        {5, -3},
        {6, -2},
        {7, -2},
        {8, -1},
        {9, -1},
        {10, 0},
        {11, 0},
        {12, 1},
        {13, 1},
        {14, 2},
        {15, 2},
        {16, 3},
        {17, 3},
        {18, 4},
        {19, 4},
        {20, 5},
        {21, 5},
        {22, 6},
        {23, 6},
        {24, 7},
        {25, 7},
        {26, 8},
        {27, 8},
        {28, 9},
        {29, 9},
        {30, 10}
    };

    Dictionary<int, double> dieAverage = new Dictionary<int, double>
    {
        {6, 3.5},
        {8, 4.5},
        {10, 5.5},
        {12, 6.5}
    };

    void Start()
    {
        System.Random random = new System.Random();
        int dwarfBonus;
        int toughBonus;
        int conBonus;
        double classDie;
        double HP;

        // Enforce that class will be found even if lower case
        string classToUpperCase = char.ToUpper(classSelection[0]) + classSelection.Substring(1);

        // Check that class selection is valid item inside of classDictionary
        if (classDictionary.ContainsKey(classToUpperCase))
        {
            Debug.Log("You picked class " + classToUpperCase + " which has a hit die of d" + classDictionary[classToUpperCase]);
        }
        else
        {
            Debug.Log("Sorry, I dont know this class type");
        }

        // Enforce that conScore is between valid ranges
        if (!(conScore <= 30 && conScore >= 1))
        {
            conScore = 1;
        }

        // Check for isHillDwarf
        if (isHillDwarf)
        {
            dwarfBonus = level++;
        }
        else
        {
            dwarfBonus = 1;
        }

        // Check for toughFeat
        if (hasToughFeat)
        {
            toughBonus = 2;
        }
        else
        {
            toughBonus = 1;
        }

        // Check for Die Choice
        if (averageDie)
        {
            classDie = dieAverage[classDictionary[classToUpperCase]]; 
        }
        else
        {
            classDie = random.Next(1, classDictionary[classToUpperCase]);
        }

        // Get Con Score Multiplier 
        conBonus = abilityScoreModifiers[conScore];


        // HP Calculation
        HP = (level * classDie) + (level * conBonus) + (level * dwarfBonus) + (level * toughBonus);

        // Final Output
        Debug.Log("My character "+ characterName + " is a level " + level + " with a CON score of " + conScore + " and " + isHillDwarf + " a Hill Dwarf and" + hasToughFeat + "Tough feat. I want the HP" + averageDie);


        // Should check isHillDwarf / hasToughFeat and averageDie / rollDie so that we can set and pass a proper value into the final output.
}



}

