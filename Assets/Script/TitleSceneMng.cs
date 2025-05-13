using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneMng : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _myCoin;
    
    void Start()
    {
        _myCoin.text += CoinManager._coinAmount.ToString();
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
