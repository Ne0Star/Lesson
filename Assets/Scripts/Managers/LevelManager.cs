using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Возможные типы AI
/// </summary>
public enum AIType
{
    Псих
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
