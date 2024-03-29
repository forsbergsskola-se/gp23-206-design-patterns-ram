using UnityEngine;

public class Tree : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public TreeSeasonColors _treeColors;
    private int _tick;
    
    void Start()
    {
        this._spriteRenderer = GetComponent<SpriteRenderer>();
        //LoadColorInfos();
        UpdateSeason();
    }
    
    void FixedUpdate()
    {
        UpdateSeason();
    }

    /// <summary>
    /// In the Tree Colors, the Artist assigned very specific values for the seasoning tree.
    /// Each tree needs to access their colors depending on how old they are.
    /// Unfortunately, this solution uses up a lot of Memory :(
    /// </summary>


    void UpdateSeason()
    {
        this._treeColors.MoveNext();
        this._spriteRenderer.color = this._treeColors.CurrentColor;
    }
}
