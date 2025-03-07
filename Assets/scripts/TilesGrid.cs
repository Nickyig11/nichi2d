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

    public TilesCell GetRandomEmptyCell()
    {
        int index = Random.Range(0,cells.Length);
        int startingIndex = index;
        while(cells[index].occupied)
        {
            index++;

            if (index >= cells.Length){
                index = 0;
            }
            if(index == startingIndex){
                return null;
            }
        }

        return cells[index];
    }

    public TilesCell GetCell(int x, int y)
    {
        if (x >= 0 && x < width && y >= 0 && y < height)
        {
            return rows[y].cells[x];
        }
        else
        {
            return null;
        }
    }

    public TilesCell GetCell(Vector2Int coordinates)
    {
        return GetCell(coordinates.x, coordinates.y);
    }

    public TilesCell GetAdjacentCell(TilesCell cell, Vector2Int direction)
    {
        Vector2Int coordinates = cell.coordinates;
        coordinates.x += direction.x;
        coordinates.y -= direction.y; 
        return GetCell(coordinates);
    }

}