using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private bool m_GameStarted;
    private static GameManager m_Instance;

    [Header("References")]
    [SerializeField] private GameObject m_Player;

    public static Action GameStarted;
    public static Action GameEnd;

    public static GameManager Instance
    {
        get { return m_Instance; }
    }

    #region Game|Level Change Behaviours
    public void StartGame()
    {
        GameStarted.Invoke();
        m_Player.SetActive(true);
    }

    public void RestartLevel()
    {
        
    }

    public void LoadNextScene()
    {

    }

    public void EndGame()
    {
        GameEnd.Invoke();

    }
    #endregion
}
