using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickXFollower : MonoBehaviour
{
    public Transform center;

    void Update()
    {
        Vector3 myPos = transform.position;
        Vector3 centerPos = center.position;

        // Z座標だけ移動
        transform.position = new Vector3(myPos.x, myPos.y, centerPos.z);
    }
}

