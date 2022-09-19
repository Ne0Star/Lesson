using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    private void OnEnable()
    {
        Enable();
    }

    protected virtual void Enable()
    {

    }

}
