using Assets._Scripts.Camera;

using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public CameraFollowTarget Camera;
    public SpawnPlayerLocation SpawnPlayerLocation;

    private string _prefabName = "Player";
    private GameObject _player;

    void Start()
    {
    }

    public void Spawn()
    {
        LoadPlayer();
        SetupCamera();
    }

    private void LoadPlayer()
    {
        var prefab = Resources.Load<GameObject>(_prefabName);

        Debug.Log(prefab);

        _player = Instantiate(prefab, SpawnPlayerLocation.transform.position, Quaternion.identity);
    }

    private void SetupCamera()
    {
        var playerTransform = _player.transform;
        Camera.Target = playerTransform;
    }
}
