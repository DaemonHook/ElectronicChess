/*
 * file: Grid.cs
 * author: D.H.
 * feature: Grid Layer(网格层，即Cell所处的层)
 */

using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject cell;
    public Vector2Int gridSize
    {
        get
        {
            return GameManager.instance.mapSize;
        }
    }

    // 访问格子的快捷方式
    public Cell[,] cells { get; private set; }

    public void Init()
    {
        CreateGrid(GameManager.instance.mapSize);
    }

    private void OnCellClicked(Cell cell)
    {
        print($"Grid: cell at {cell.worldPosition} is clicked!");
    }

    private void CreateGrid(Vector2Int size)
    {
        cells = new Cell[size.x, size.y];

        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                GameObject go = Instantiate(cell, this.transform);
                go.transform.position = new Vector2(i, j);
                Cell curCell = go.GetComponent<Cell>();
                cells[i, j] = curCell;
                curCell.Init(
                    new Vector2Int(i, j),
                    () =>
                    {
                        OnCellClicked(curCell);
                    }
                );
            }
        }

        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                cells[i, size.y - 1].BorderedModeUp();
                cells[size.x - 1, j].BorderedModeRight();
            }
        }
    }
}
