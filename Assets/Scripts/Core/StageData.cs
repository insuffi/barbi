using UnityEngine;

[CreateAssetMenu(fileName = "NewStageData", menuName = "MiniPrincess/Stage Data")]
public class StageData : ScriptableObject
{
    public string stageName;
    public Sprite backgroundSprite;
    public Sprite characterBaseSprite;

    public Color themeColor = Color.white;

    public Sprite[] freeDressOptions;
    public Sprite[] premiumDressOptions;

    public Sprite[] freeHairOptions;
    public Sprite[] premiumHairOptions;

    public Sprite[] makeupOptions;
}