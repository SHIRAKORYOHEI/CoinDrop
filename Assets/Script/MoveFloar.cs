using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveFloar : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(0, 0.25f, (Mathf.Sin(Time.time) + 4f) * 0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Transform childTransform = transform.GetChild(0);
            other.gameObject.transform.parent = childTransform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.transform.parent = null;
        }
    }
}
