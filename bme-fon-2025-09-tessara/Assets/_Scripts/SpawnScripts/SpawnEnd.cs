using UnityEngine;

public class SpawnEnd : MonoBehaviour
{
    public SpawnEndLocation SpawnEndLocation;

    private string _prefabName = "End";

    public void Spawn()
    {
        LoadEnd();
    }

    private void LoadEnd()
    {
        var prefab = Resources.Load<GameObject>(_prefabName);

        Instantiate(prefab, SpawnEndLocation.transform.position, Quaternion.identity);
    }
}
