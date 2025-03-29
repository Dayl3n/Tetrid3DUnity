using System;
using UnityEngine;

public enum TetronimoType
{
    I,
    O,
    T,
    S,
    Z,
    J,
    L
}

[Serializable]
public struct TetronimoData
{
    public TetronimoType type;
    public GameObject prefab;
}


