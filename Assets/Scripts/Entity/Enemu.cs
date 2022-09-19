using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemu : Entity
{
    [SerializeField] private AI ai;
    [SerializeField] private AIType aiType;

    protected void ChangeAI()
    {
        LevelManager.Instance.AiManager.ChangeAI(this, ref ai, aiType);
    }

    protected override void Enable()
    {
        ChangeAI();
    }

}
