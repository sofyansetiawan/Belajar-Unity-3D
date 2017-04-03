using UnityEngine;
using TinyTerrain;

public class FaceNormal : TextureCallback
{
    const float MaxRadial = .6f;
    public override Color GetColor(float plantyNess, float radialDistance, Vector3 position, Vector3 normal, Vector3 faceNormal)
    {
        float radialScale = 1;
        if(radialDistance > MaxRadial)
        {
            radialScale = Mathf.Min(1, (radialDistance - MaxRadial) * 10);
            radialScale = 1 - radialScale;
        }

        float normalScale = Mathf.Max(0, faceNormal.y - .8f) * 5;
        return new Color(normal.x, normal.y, normal.z, plantyNess * normalScale * radialScale);
    }
}