using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.right * Time.deltaTime;
    }
}
