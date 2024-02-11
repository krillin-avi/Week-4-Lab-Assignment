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
    public bool hasToughFeat;



    // Static Values
    public int conScore;
    public bool averageDie;
    public bool rollDie;

    Dictionary<int, double> dieAverage = new Dictionary<int, double>
    {
        {6, 3.5},
        {8, 4.5},
        {10, 5.5},
        {12, 6.5}
    };

    void Start()
    {
        Character character = new Character(characterNameBoo, level, classSelection, isHillDwarf, hasToughFeat);
        ConScore conScoreValue = new ConScore(conScore);


        Debug.Log(character.Print());
        

    }

   /* public int CaculatedAvgDie(int hitdie)
    {
        dieAverage[hitdie];
    }
   */
    
}


