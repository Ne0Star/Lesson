using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{


    public void ChangeAI(Entity sources, ref AI last, AIType type)
    {
        if (last != null)
        {
            Destroy(last.gameObject);
            last = AddAI(sources, type);
        }
        else
        {
            last = AddAI(sources, type);
        }
    }

    private AI AddAI<T>(ref Entity sources, string name) where T : Component
    {
        GameObject obj = new GameObject("Ai: " + name);
        obj.transform.parent = sources.transform;
        AI result = obj.gameObject.AddComponent<T>() as AI;
        return result;
    }

    public AI AddAI(Entity sources, AIType type)
    {
        switch (type)
        {
            case AIType.ѕсих:
                return AddAI<PsychoAI>(ref sources, "ѕсих");
        }
        return null;
    }
}
