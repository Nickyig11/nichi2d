using UnityEngine;

public class TilesGrid : MonoBehaviour
{
    public TilesRow[] rows { get; private set; }
    public TilesCell[] cells { get; private set; }

    public int size => cells.Length;
    public int height => rows.Length;
    public int width => size / height;

    private void Awake()
    {
        rows = GetComponentsInChildren<TilesRow>();
        cells = GetComponentsInChildren<TilesCell>();
    }
    private void Start()
    {
        for (int y = 0; y< rows.Length; y++)
        {
            for(int x = 0; x< rows[y].cells.Length; x++)
            {
                rows[y].cells[x].coordinates = new Vector2Int(x,y);
            }
        }
    }
}