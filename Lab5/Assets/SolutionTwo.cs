using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionTwo : MonoBehaviour
{
    void Start()
    {
        
        
        //NameWillChange nameWillChange = new NameWillChange();
        //nameWillChange(characterName);

    }

    
}

public class SolutionTwoOutput 
{
    public string characterName;
    public int level;
    public string classSelection;
    public int conScore;
    public bool isHillDwarf;
    public bool hasToughFeat;
    public bool averageDie;
    public bool rollDie;



    SolutionTwoOutput(string name, int level, string classChoice)
    { 
        this.characterName = name;
        this.level = level;
        this.classSelection = classChoice;
        
    }

    void ReturnOutput()
    {
        return this.characterName;
    }

   

   
}
