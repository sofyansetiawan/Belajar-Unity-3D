using TinyTerrain;
using System;
using UnityEngine;

public class Plants : PrefabCallback
{
    const float ChanceOfPlant = .25f;
    const float MinY = 0;
    const float MinPlantyness = .9f;

    System.Random random = new System.Random(0);

    public override Func<GameObject> GetPrefab(GameObject[] prefabs, float plantyNess, float radialDistance, Vector3 position, Vector3 normal, Vector3 faceNormal)
    {
        if (prefabs.Length == 0)
        {
            return null;
        }

        if (position.y < MinY)
        {
            return null;
        }

        if (plantyNess < MinPlantyness)
        {
            return null;
        }

        if(random.NextDouble() > ChanceOfPlant)
        {
            return null;
        }

        if(faceNormal.y < .95)
        {
            return null;
        }

        return () =>
        {
            var instance = GameObject.Instantiate(prefabs[random.Next(prefabs.Length)]) as GameObject;
            instance.transform.position = position;
            return instance;
        };
    }
}