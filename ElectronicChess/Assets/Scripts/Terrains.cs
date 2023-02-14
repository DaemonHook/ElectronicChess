/*
 * file: Terrains.cs
 * author: D.H.
 * feature: 地形单位
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrains : MonoBehaviour
{
    /// <summary>
    /// 障碍层级
    /// </summary>
    [Header("被其阻拦单位的层级")]
    public List<UnitLayer> blockedLayers;

    [Header("地形加成")]
    public float terrainAddition = 1.0f;

    [Header("跨越地形所需MP")]
    public int toll = 0;
    /// <summary>
    /// 单位是否被地形
    /// </summary>
    /// <param name="piece"></param>
    /// <returns></returns>
    public bool IsBlocked(Piece piece)
    {
        return blockedLayers.Contains(piece.layer);
    }

}
