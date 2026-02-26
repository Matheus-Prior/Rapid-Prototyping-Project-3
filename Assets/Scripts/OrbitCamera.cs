using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform player;

    public float rotationSpeed = 80f;
    public float heightOffset = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        // Rotate around beanstalk
        transform.Rotate(Vector3.up * horizontal * rotationSpeed * Time.deltaTime);

        // Follow player upward
        Vector3 pos = transform.position;
        pos.y = player.position.y + heightOffset;
        transform.position = pos;

        // Always face player
        transform.LookAt(player);
    }
}