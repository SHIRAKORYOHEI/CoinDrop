
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinManager : MonoBehaviour
{
    public GameObject _coin;
    public static int _coinAmount;
    [SerializeField] private TextMeshProUGUI _coinText;
    [SerializeField] private GameObject _center;

    void Start()
    {
        for (int i = 0; i < 120; i++)
        {
            Instantiate(_coin, new Vector3(Random.Range(-1f,1f),1,Random.Range(-0.5f,1f)), Quaternion.identity);
        }
    }
    
    void Update()
    {
        _coinText.text = _coinAmount.ToString();
        
        
        if (Input.GetKeyDown(KeyCode.Space) && _coinAmount > 0)
        {
            Instantiate(_coin, new Vector3(_center.transform.position.x,_center.transform.position.y - 0.21f,_center.transform.position.z), Quaternion.identity);
            --_coinAmount;
        }
    }
}
