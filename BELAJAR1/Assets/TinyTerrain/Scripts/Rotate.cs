using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationsPerSecond = .1f;

    void Update()
    {
        this.transform.eulerAngles += Time.deltaTime * Vector3.up * rotationsPerSecond * 360;
    }
}
