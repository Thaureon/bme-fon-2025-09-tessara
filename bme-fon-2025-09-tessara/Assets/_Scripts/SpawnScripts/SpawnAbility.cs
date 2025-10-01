using Assets._Scripts.Player.Abilities;

using UnityEngine;

public class SpawnAbility : MonoBehaviour
{
    public SpawnAbilityLocation SpawnAbilityLocation;
    public Ability DesiredAbility;

    private string _prefabName = "Ability";

    public void Spawn()
    {
        LoadAbility();
    }

    private void LoadAbility()
    {
        var prefab = Resources.Load<GameObject>(_prefabName);

        var newAbility = Instantiate(prefab, SpawnAbilityLocation.transform.position, Quaternion.identity);

        newAbility.GetComponentInChildren<ActivateAbility>().AbilityName = DesiredAbility;
    }
}
