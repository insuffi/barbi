using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class DressSceneUI : MonoBehaviour
{
    [Header("Character")]
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer dressRenderer;
    public SpriteRenderer hairRenderer;

    [Header("UI")]
    public TMP_Text stageTitleText;

    [Header("Free Dress Buttons")]
    public Button[] freeDressButtons;

    [Header("Premium Dress Buttons")]
    public Button[] premiumDressButtons;

    [Header("Dress Colors")]
    public Color[] freeDressColors;
    public Color[] premiumDressColors;

    private void Start()
    {
        RefreshStageUI();
        BindButtons();
    }

    void RefreshStageUI()
    {
        StageData currentStage = GameManager.Instance.GetCurrentStage();

        if (currentStage != null && stageTitleText != null)
        {
            stageTitleText.text = currentStage.stageName + " - Elbise Seç";
        }
    }

    void BindButtons()
    {
        for (int i = 0; i < freeDressButtons.Length; i++)
        {
            int index = i;
            freeDressButtons[i].onClick.RemoveAllListeners();
            freeDressButtons[i].onClick.AddListener(() => SelectFreeDress(index));
        }

        for (int i = 0; i < premiumDressButtons.Length; i++)
        {
            int index = i;
            premiumDressButtons[i].onClick.RemoveAllListeners();
            premiumDressButtons[i].onClick.AddListener(() => SelectPremiumDress(index));
        }
    }

    public void SelectFreeDress(int index)
    {
        if (index >= 0 && index < freeDressColors.Length)
        {
            dressRenderer.color = freeDressColors[index];
            GameManager.Instance.SelectDress(index);
        }
    }

    public void SelectPremiumDress(int index)
    {
        if (index >= 0 && index < premiumDressColors.Length)
        {
            dressRenderer.color = premiumDressColors[index];
            GameManager.Instance.SelectDress(100 + index);
        }
    }

    public void GoToHairScene()
    {
        SceneManager.LoadScene("HairScene");
    }
}