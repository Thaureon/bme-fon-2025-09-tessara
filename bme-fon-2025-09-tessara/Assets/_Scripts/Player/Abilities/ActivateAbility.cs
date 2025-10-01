using UnityEngine;

namespace Assets._Scripts.Player.Abilities
{
    public class ActivateAbility : MonoBehaviour
    {
        public Ability AbilityName;

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                var abilityComponent = GetAbilityComponent(collision.gameObject);
                abilityComponent.enabled = true;
                gameObject.SetActive(false);
            }
        }

        private MonoBehaviour GetAbilityComponent(GameObject playerObject)
        {
            switch (AbilityName)
            {
                case Ability.Jump:
                    return playerObject.GetComponent<PlayerJump>();
                case Ability.Crawl:
                    return playerObject.GetComponent<PlayerCrawl>();
                default:
                    return null;
            }
        }
    }
}
