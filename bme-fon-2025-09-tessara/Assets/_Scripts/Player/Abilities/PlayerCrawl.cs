using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets._Scripts.Player.Abilities
{
    public class PlayerCrawl : MonoBehaviour
    {
        public bool StuckCrawling = false;
        public Transform SpritePosition;

        private bool _crawling;
        private bool _triedStanding;

        private InputAction _crawlAction;
        private PlayerStats _playerStats;
        private BoxCollider2D _bodyBox;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _crawlAction = InputSystem.actions.FindAction("Crouch");
            _playerStats = gameObject.GetComponent<PlayerStats>();
            _bodyBox = gameObject.GetComponent<BoxCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_crawlAction.WasPerformedThisFrame())
            {
                _crawling = true;
                _triedStanding = false;
                if (_crawling)
                {
                    StartCrawling();
                }
            }
            else if (_crawlAction.WasReleasedThisFrame())
            {
                _triedStanding = true;
                if (!_playerStats.HeadBlocked)
                {
                    _crawling = false;
                }
                if (!_crawling)
                {
                    StopCrawling();
                }
            }

            if (_crawling && !_playerStats.HeadBlocked && _triedStanding)
            {
                _crawling = false;
                if (!_crawling)
                {
                    StopCrawling();
                }
            }
        }

        private void StartCrawling()
        {
            AdjustSprite(0.5f, 0.5f);
            AdjustBodyBox(0.5f, 1.0f);
        }

        private void StopCrawling()
        {
            AdjustSprite(1.0f, 1.0f);
            AdjustBodyBox(1.0f, 2.0f);
        }

        private void AdjustSprite(float height, float position)
        {
            SpritePosition.localScale = new Vector3(1.0f, height, 1.0f);
            SpritePosition.localPosition = new Vector3(0, position, 0);
        }

        private void AdjustBodyBox(float offset, float size)
        {
            _bodyBox.offset = new Vector2(_bodyBox.offset.x, offset);
            _bodyBox.size = new Vector2(_bodyBox.size.x, size);
        }
    }
}
