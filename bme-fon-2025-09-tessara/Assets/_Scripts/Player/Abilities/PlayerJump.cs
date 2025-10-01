using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets._Scripts.Player.Abilities
{
    public class PlayerJump : MonoBehaviour
    {
        public bool Jumping = false;

        private Vector2 _jump;


        private InputAction _jumpAction;
        private PlayerStats _playerStats;
        private Rigidbody2D _rb;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _jumpAction = InputSystem.actions.FindAction("Jump");
            _playerStats = gameObject.GetComponent<PlayerStats>();
            _rb = GetComponent<Rigidbody2D>();

            _jump = new Vector2(0.0f, 1.0f);
        }

        void OnCollisionStay2D()
        {
            Jumping = false;
        }

        void OnCollisionExit2D()
        {
            Jumping = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (!Jumping && _jumpAction.triggered)
            {
                _rb.AddForce(_playerStats.JumpForce * _jump, ForceMode2D.Impulse);
            }
        }
    }
}
