using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 cameraOffset;

    [Range(0.1f, 1.0f)]
    public float smoothness = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = player.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothness);
    }
}
