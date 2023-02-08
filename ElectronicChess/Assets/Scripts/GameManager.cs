using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 游戏界面的三个组成元素：网格，地形，单位
    public GameObject gridGO, terrainGO, unitsGO;

    private Grid grid;

    private void Awake()
    {
        grid = gridGO.GetComponent<Grid>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
