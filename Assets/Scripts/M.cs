using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class M
{
    private static Prefabs prefabs;
    public static Prefabs Prefabs
    {
        get
        {
            if (prefabs == null)
            {
                prefabs = GameObject.Find("Prefabs").GetComponent<Prefabs>();
            }
            return prefabs;
        }
    }
}
