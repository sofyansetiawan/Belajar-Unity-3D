using UnityEngine;
using System.Collections;
using TinyTerrain;
using System;

public class EnableStatic : TerrainSurfaceCallback
{
    public override void ProcessTerrainSurface(GameObject terrain, ITerrainSurface terrainSurface)
    {
        // Make root GameObject static
        terrain.isStatic = true;

        // Make children straic
        for(var i = 0; i < terrain.transform.childCount; i++)
        {
            terrain.transform.GetChild(i).gameObject.isStatic = true;
        }
    }
}
