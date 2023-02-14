using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MapData
{
    public string name;
    public int[] size;

    public string terrainNames;
    public Vector2Int[] terrainPositions;

    public string unitNames;
}

public class MapServer : MonoBehaviour
{
    public static MapServer instance;

    private List<string> mapList;
    private Dictionary<string, string> mapDict;

    private void Awake()
    {
        instance = this;
    }

    private void LoadMaps()
    {
        var maps = Resources.LoadAll<TextAsset>("Maps");
        foreach (var map in maps)
        {
            mapList.Add(map.name);
            print(map.name);
        }
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
