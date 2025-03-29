using Unity.Entities;
using UnityEngine;

public partial class BlockSpawnerAuthoring : MonoBehaviour
{
    public TetronimoData[] tetronimos; 
    public bool isSpawning = true;
}

class BlockSpawnerBaker : Baker<BlockSpawnerAuthoring>
{
    public override void Bake(BlockSpawnerAuthoring authoring)
    {
        Entity entity = GetEntity(TransformUsageFlags.None);

        AddComponent(entity, new BlockSpawnerComponent
        {
            blockPrefab = GetEntity(authoring.tetronimos[0].prefab, TransformUsageFlags.Dynamic),
            isSpawning = authoring.isSpawning,
            spawnPos = authoring.transform.position
        });
    }
}