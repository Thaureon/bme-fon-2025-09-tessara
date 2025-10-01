using UnityEngine;
using UnityEngine.InputSystem;

using Vector2 = UnityEngine.Vector2;

namespace Assets._Scripts.Player
{
    public class Movement2D : MonoBehaviour
    {
        public float Speed = 10;
        public float CurrentSpeed = 0;
        public float Acceleration = 0.2f;
        public float MovingSpeed = 0;

        private Rigidbody2D _rb;
        private InputAction _moveAction;

        // Start is called before the first frame update
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _moveAction = InputSystem.actions.FindAction("Move");

        }

        // Update is called once per frame
        void Update()
        {
            var movement = _moveAction.ReadValue<Vector2>();
            var direction = movement.x;

            _rb.position += new Vector2(Speed * direction, 0) * Time.deltaTime;
        }
    }
}
