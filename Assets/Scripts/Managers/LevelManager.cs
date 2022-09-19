using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ��������� ���� AI
/// </summary>
public enum AIType
{
    ����
}

public class LevelManager : OneSingleton<LevelManager>
{
    [SerializeField] private AIManager aiManager;

    public AIManager AiManager { get => aiManager; }

    private void Awake()
    {
        LevelManager.Instance = this;
        aiManager = FindObjectOfType<AIManager>();
    }
}
