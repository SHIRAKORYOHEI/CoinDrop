using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickZFollower : MonoBehaviour
{
    public Transform center;

    void Update()
    {
        Vector3 myPos = transform.position;
        Vector3 centerPos = center.position;

        // X座標だけ移動
        transform.position = new Vector3(centerPos.x, myPos.y, myPos.z);
    }
}

