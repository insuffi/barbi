using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public StageData[] stages;

    public GameState gameState = new GameState();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public StageData GetCurrentStage()
    {
        if (stages == null || stages.Length == 0) return null;

        int index = Mathf.Clamp(gameState.currentStageIndex, 0, stages.Length - 1);
        return stages[index];
    }

    public void SelectDress(int index)
    {
        gameState.selectedDressIndex = index;
    }

    public void SelectHair(int index)
    {
        gameState.selectedHairIndex = index;
    }

    public void SelectMakeup(int index)
    {
        gameState.selectedMakeupIndex = index;
    }

    public void NextStage()
    {
        gameState.currentStageIndex++;
        gameState.selectedDressIndex = -1;
        gameState.selectedHairIndex = -1;
        gameState.selectedMakeupIndex = -1;
    }
}