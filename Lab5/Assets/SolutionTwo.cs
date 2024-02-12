using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionTwo : MonoBehaviour
{
    // Overloaded Values
    public string characterNameBoo;
    public int level;
    public string classSelection;
    public bool isHillDwarf;
    private string hillDwarf = "is" ;
    public bool hasToughFeat;
    private string toughFeat = "has";
    
    // Static Values
    public int conScore;
    public bool averageDie;
    public bool rollDie;

    // Global Values
    int classHitDieValue;
    int calculatedConScore;
    double conBonus;
    

    Dictionary<int, double> dieAverage = new Dictionary<int, double>
    {
        {6, 3.5},
        {8, 4.5},
        {10, 5.5},
        {12, 6.5}
    };

    void Start()
    {
        // Placeholder Var
        double HP;

        Character character = new Character(characterNameBoo, level, classSelection, isHillDwarf, hasToughFeat);
        ConScore conScoreValue = new ConScore(conScore);

        classHitDieValue = character.GetClassCheckedValue();
        calculatedConScore = conScoreValue.CalculatedConScore();

        conBonus = classHitDieValue + calculatedConScore;


        if (!isHillDwarf )
        {
            hillDwarf = "is not";
        }

        if (!hasToughFeat)
        {
            toughFeat = "does not have";
        }
    


        // Player Details Output
        Debug.Log("My character " + character.GetName() + " is a level " + character.GetLevel() + " " + character.GetClassSelection() + " with a CON score of " + conScore + " and " + hillDwarf + " a Hill Dwarf and " + toughFeat + " Tough feat. I want the HP " + averageDie);

        // Player HP Output
        HP = (level * classHitDieValue) + (level * conBonus) + (level * character.GetDwarfBonus()) + (level * character.GetToughBonus());
        Debug.Log(character.GetName() + " your calculated HP is: " + HP);
    }

    double CaculatedAvgDie(int classHitDieValue)
    {
        return dieAverage[classHitDieValue];
    }

    int RandomRoll()
    {
        return Random.Range(1, classHitDieValue);
    }
    
}


