/*
 * file: Mask.cs
 * author: D.H.
 * feature: Cell…œµƒ’⁄’÷≤„
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public Color normal, passable, blocked, fogged, buildable, attackable;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchMode(string mode)
    {
        Color c = normal;
        switch (mode)
        {
            case "normal":
                c = normal; break;
            case "passable":
                c = passable; break;
            case "blocked":
                c = blocked; break;
            case "fogged":
                c = fogged; break;
            case "buildable":
                c = buildable; break;
            case "attackable":
                c = attackable; break;
        }
        GetComponent<SpriteRenderer>().color = c;
    }
}
