using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenControl : MonoBehaviour
{
    private player Player;
    private Vector3 lastPosition;
    private float distance;

    void Start()
    {
        Player = FindObjectOfType<player>();
        lastPosition = Player.transform.position;
    }

    void Update()
    {
        distance = Player.transform.position.x - lastPosition.x;
        transform.position = new Vector3(
            transform.position.x + distance,
            transform.position.y,
            transform.position.z
        );
        lastPosition = Player.transform.position;
    }
}
