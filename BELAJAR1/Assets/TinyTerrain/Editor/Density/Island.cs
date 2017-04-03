using UnityEngine;
using System.Collections;
using TinyTerrain;
using System;

public class Island : DensityCallback
{
    const float InnerSizePercentage = .5f;
    const float FloorLevel = -40;

    public override float GetDensity(float fractalSample, float radialDistance, Vector3 position)
    {
        if(radialDistance >= 1)
        {
            return 0;
        }

        radialDistance -= InnerSizePercentage;
        if (radialDistance < 0)
        {
            radialDistance = 0;
        }
        radialDistance /= (1 - InnerSizePercentage);

        return fractalSample - radialDistance * 2 - Math.Min(position.y - FloorLevel, 0);
    }
}
