using UnityEngine;
using TinyTerrain;

public class FractalAndDensityNormal : TextureCallback
{
    /// <summary>
    /// Simple callback for getting the color of a point on the terrain.
    /// </summary>
    /// <returns></returns>
    public override Color GetColor(float plantyNess, float radialDistance, Vector3 position, Vector3 normal, Vector3 faceNormal)
    {
        float normalScale = Mathf.Max(0, normal.y - .8f) * 5;
        float radialScale = 1 - radialDistance * radialDistance * radialDistance * radialDistance * radialDistance;

        return new Color(normal.x, normal.y, normal.z, plantyNess * normalScale * radialScale);
    }
}