using UnityEngine;

public class SpawnAbility : MonoBehaviour
{
    public SpawnAbilityLocation SpawnAbilityLocation;

    private string _prefabName = "Ability";

    public void Spawn()
    {
        LoadAbility();
    }

    private void LoadAbility()
    {
        var prefab = Resources.Load<GameObject>(_prefabName);

        Instantiate(prefab, SpawnAbilityLocation.transform.position, Quaternion.identity);
    }
}
