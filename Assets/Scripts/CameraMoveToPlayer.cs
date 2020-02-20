using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveToPlayer : MonoBehaviour
{
    public Transform player;

    private Vector3 currentPosition;
    void LateUpdate()
    {
        var position = player.position;
        currentPosition.Set(position.x, position.y, -10);
        transform.position = currentPosition;
    }
}
