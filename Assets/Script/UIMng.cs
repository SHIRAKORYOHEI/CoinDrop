using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMng : MonoBehaviour
{
    [SerializeField] private GameObject _titleButton;
    [SerializeField] private GameObject _resumeButton;

    void Start()
    {
        _titleButton.SetActive(false);
        _resumeButton.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            
            _titleButton.SetActive(true);
            _resumeButton.SetActive(true);
        }
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
        _titleButton.SetActive(false);
        _resumeButton.SetActive(false);
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
