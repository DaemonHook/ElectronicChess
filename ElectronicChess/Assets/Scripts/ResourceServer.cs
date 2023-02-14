using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class ResourceServer : MonoBehaviour
{
    public static ResourceServer instance;

    /// <summary>
    /// ������ҵ�λ
    /// </summary>
    /// <param name="name">��λ����</param>
    /// <returns>����������Ϊnull</returns>
    public GameObject RequestPiece(string name)
    {
        if (!pieceDict.ContainsKey(name.ToLower()))
        {
            Debug.LogError($"ResourceServer: Error loading piece {name}");
        }
        return pieceDict[name.ToLower()];
    }

    /// <summary>
    /// ������ε�λ
    /// </summary>
    /// <param name="name">��λ����</param>
    /// <returns>����������Ϊnull</returns>
    public GameObject RequestTerrain(string name)
    {
        if (!terrainDict.ContainsKey(name.ToLower()))
        {
            Debug.LogError($"ResourceServer: Error loading terrain {name}");
        }
        return terrainDict[name.ToLower()];
    }

    private Dictionary<string, GameObject> pieceDict;

    private Dictionary<string, GameObject> terrainDict;

    private void LoadPieces()
    {
        pieceDict = new Dictionary<string, GameObject>();
        var all = Resources.LoadAll<GameObject>("Prefabs/Units");
        foreach (var piece in all)
        {
            pieceDict.Add(piece.name.ToLower(), piece);
            print($"{piece.name} added!");
        }
    }

    private void LoadTerrains()
    {
        terrainDict = new Dictionary<string, GameObject>();
        var all = Resources.LoadAll<GameObject>("Prefabs/Terrains");
        foreach (var piece in all)
        {
            pieceDict.Add(piece.name.ToLower(), piece);
            print($"{piece.name} added!");
        }
    }

    private void LoadAllResources()
    {
        LoadPieces();
        LoadTerrains();
    }

    private void Awake()
    {
        instance = this;
        LoadAllResources();
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
