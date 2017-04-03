using UnityEngine;
using System.Collections;
using TinyTerrain;
using System;

public class InverseHill : DensityCallback
{
    // Difference in height between center and edge so that mountains stand out
    const float HeightOffset = .25f;

    public override float GetDensity(float fractalSample, float radialDistance, Vector3 position)
    {
        radialDistance -= .75f;
        if (radialDistance < 0)
        {
            radialDistance = 0;
        }
        radialDistance *= 4;

        return Mathf.Lerp(fractalSample + HeightOffset / 2, -.01f * position.y - HeightOffset / 2, 1 - radialDistance);
    }
}
