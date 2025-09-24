using UnityEngine;

public class GenerateWorld : MonoBehaviour
{
    public GameObject LevelLayout;

    private SpawnPlayer _spawnPlayer;
    private SpawnAbility _spawnAbility;
    private SpawnEnd _spawnEnd;

    void Start()
    {
        _spawnPlayer = GetComponent<SpawnPlayer>();
        _spawnAbility = GetComponent<SpawnAbility>();
        _spawnEnd = GetComponent<SpawnEnd>();

        _spawnPlayer.SpawnPlayerLocation = LevelLayout.GetComponentInChildren<SpawnPlayerLocation>();
        _spawnAbility.SpawnAbilityLocation = LevelLayout.GetComponentInChildren<SpawnAbilityLocation>();
        _spawnEnd.SpawnEndLocation = LevelLayout.GetComponentInChildren<SpawnEndLocation>();

        _spawnPlayer.Spawn();
        //_spawnAbility.Spawn();
        _spawnEnd.Spawn();
    }
}
