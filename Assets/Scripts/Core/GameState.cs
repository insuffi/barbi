using UnityEngine;

[System.Serializable]
public class GameState
{
    public int currentStageIndex = 0;

    public int selectedDressIndex = -1;
    public int selectedHairIndex = -1;
    public int selectedMakeupIndex = -1;

    public bool[] unlockedPremiumDressItems;
    public bool[] unlockedPremiumHairItems;
}