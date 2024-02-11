public class Character
{
    string characterName;
    int level;
    string classSelection;
    bool isHillDwarf;
    bool hasToughFeat;


    public Character()
    {
        characterName = "Christian";
    }

    public Character(string characterName, int level, string classSelection, bool isHillDwarf, bool hasToughFeat)
    {
        this.characterName = characterName;
        this.level = level;
        this.classSelection = classSelection;
        this.isHillDwarf = isHillDwarf;
        this.hasToughFeat = hasToughFeat;
    }


    public string ReturnTest()
    {
        return characterName;
    }

}
