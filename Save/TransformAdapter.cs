using UnityEngine;

public class TransformAdapter : ISaveableData
{
    private Transform transform;
    
    public TransformAdapter(Transform transform)
    {
        this.transform = transform;
    }

    public void Load(string data)
    {
        throw new System.NotImplementedException();
    }

    public string Save()
    {
        throw new System.NotImplementedException();
    }
}