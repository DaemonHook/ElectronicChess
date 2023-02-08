/*
 * file: Grid.cs
 * author: D.H.
 * feature: 网格层，即Cell所处的层
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject cell;
    public Vector2Int size;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(Vector2Int size)
    {
        CreateGrid(size);
    }

    private void CreateGrid(Vector2Int size)
    {
        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                GameObject go = Instantiate(cell, this.transform);
                go.transform.position = new Vector2(i, j);
                go.GetComponent<Cell>().Init(new Vector2Int(i, j));
            }
        }
    }
}
