/*
 * file: Terrains.cs
 * author: D.H.
 * feature: ���ε�λ
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrains : MonoBehaviour
{
    /// <summary>
    /// �ϰ��㼶
    /// </summary>
    [Header("����������λ�Ĳ㼶")]
    public List<UnitLayer> blockedLayers;

    [Header("���μӳ�")]
    public float terrainAddition = 1.0f;

    [Header("��Խ��������MP")]
    public int toll = 0;
    /// <summary>
    /// ��λ�Ƿ񱻵���
    /// </summary>
    /// <param name="piece"></param>
    /// <returns></returns>
    public bool IsBlocked(Piece piece)
    {
        return blockedLayers.Contains(piece.layer);
    }

}
