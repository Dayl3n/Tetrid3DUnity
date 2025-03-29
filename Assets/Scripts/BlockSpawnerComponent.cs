using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;


public struct BlockSpawnerComponent : IComponentData
{
    public Entity blockPrefab;
    public float3 spawnPos;
    public bool isSpawning;
}