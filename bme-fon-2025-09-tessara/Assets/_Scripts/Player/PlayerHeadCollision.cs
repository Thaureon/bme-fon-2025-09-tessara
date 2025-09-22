
using UnityEngine;

public class PlayerHeadCollision : MonoBehaviour
{

    private PlayerStats _playerStats;
    void Start()
    {
        _playerStats = gameObject.GetComponentInParent<PlayerStats>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _playerStats.HeadBlocked = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        _playerStats.HeadBlocked = false;
    }
}
