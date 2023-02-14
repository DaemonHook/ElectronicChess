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

    private GridLayer grid;
    
    #endregion

    #region 游戏全局设置
    public Vector2Int mapSize { get; private set; }
    
    [Header("点击灵敏度")]
    public float clickSensitivity;

    [Header("队伍颜色")]
    public List<Color> teamColors;
    #endregion

    #region 游戏状态
    public bool inDrag = false;
    #endregion

    #region 测试
    [Header("地图大小")]
    public Vector2Int size;
    #endregion

    private void Awake()
    {
        instance = this;
        grid = gridGO.GetComponent<GridLayer>();
    }

    private void InitGame()
    {
        grid.Init();

        cameraMove.Init(new Vector2(mapSize.x, mapSize.y), 
            new Vector2(mapSize.x / 2 - 0.5f, mapSize.y / 2 - 0.5f));
    }

    // Start is called before the first frame update
    void Start()
    {
        // TEST
        mapSize = size;
        //
        InitGame();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
