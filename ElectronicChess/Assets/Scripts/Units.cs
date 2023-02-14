/*
 * file: Units.cs
 * author: D.H.
 * feature: Units layer（单位层）
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 单位所处层级
/// </summary>
public enum UnitLayer
{
    Ground,     // 地面单位
    Aquatic,    // 水中单位
    Air         // 空中单位
}

/// <summary>
/// 单位类型
/// </summary>
public enum UnitType
{
    Building,   // 建筑
    Warrior     // 战士
}

public class Units : MonoBehaviour
{
    public static Units instance;

    public Piece[,] units;

    public void Init(List<(Vector2Int, string)> initialUnits)
    {
        units = new Piece[GameManager.instance.mapSize.x, GameManager.instance.mapSize.y];

        foreach (var pair in initialUnits)
        {
            GameObject piecePrefab = ResourceServer.instance.RequestPiece(pair.Item2);
            if (piecePrefab != null)
            {

            }
        }

    }

    private void Awake()
    {
        instance = this;
    }

}
