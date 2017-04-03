using UnityEngine;
using System.Collections;
using TinyTerrain;
using System;

public class Hill : DensityCallback
{
    public override float GetDensity(float fractalSample, float radialDistance, Vector3 position)
    {
        radialDistance -= .75f;
        if (radialDistance < 0)
        {
            radialDistance = 0;
        }
        radialDistance *= 4;

        return Mathf.Lerp(fractalSample, -.01f * position.y, radialDistance);
    }
}
