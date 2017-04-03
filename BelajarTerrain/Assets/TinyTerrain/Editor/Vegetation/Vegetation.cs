using TinyTerrain;
using System;
using UnityEngine;

/// <summary>
/// This script will randomly place a plant at each sample point where the normal.y value > .95.
/// </summary>
public class Vegetation : PrefabCallback
{
    private const float MinimumYValue = .95f;
    private const float ChanceOfPlant = .25f;
    private const float MinScale = 1.0f;
    private const float MaxScale = 2.0f;

    private System.Random random = new System.Random(0);

    public override Func<GameObject> GetPrefab(GameObject[] prefabs, float plantyNess, float radialDistance, Vector3 position, Vector3 normal, Vector3 faceNormal)
    {
        if (prefabs.Length == 0)
        {
            return null;
        }

        if(faceNormal.y < MinimumYValue)
        {
            return null;
        }

        if(random.NextDouble() > ChanceOfPlant)
        {
            return null;
        }

        var scale = Mathf.Lerp(MinScale, MaxScale, (float)random.NextDouble()) * Vector3.one;
        var rotation = new Vector3(0, (float)random.NextDouble() * 360.0f, 0);

        return () =>
        {
            var instance = GameObject.Instantiate(prefabs[0]) as GameObject;
            instance.transform.position = position;
            instance.transform.localEulerAngles = rotation;
            instance.transform.localScale = scale;
            return instance;
        };
    }
}