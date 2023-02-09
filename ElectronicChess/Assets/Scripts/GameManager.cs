using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    #region 游戏元素的引用
    // 摄像头控制
    public CameraMove cameraMove;

    // 游戏界面的三个组成元素：网格，地形，单位
    public GameObject gridGO, terrainGO, unitsGO;

    private Grid grid;
    
    #endregion

    #region 游戏全局设置
    public Vector2Int mapSize { get; private set; }

    #endregion

    #region 游戏状态
    public bool inDrag = false;
    #endregion

    private void Awake()
    {
        instance = this;
        grid = gridGO.GetComponent<Grid>();


    }

    private void InitGame()
    {
        grid.Init();

        cameraMove.Init(new Vector2(mapSize.x, mapSize.y), 
            new Vector2(math.min(4.0f, (float)mapSize.x / 2), math.min(4.0f, (float)mapSize.y / 2)));
    }

    // Start is called before the first frame update
    void Start()
    {
        // TEST
        mapSize = new Vector2Int(30, 20);
        //
        InitGame();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
