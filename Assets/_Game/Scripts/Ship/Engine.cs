using UnityEditor.VersionControl;
using UnityEngine;
using Variables;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Engine : MonoBehaviour
    {
        [SerializeField] private GameSettings _gameSettings;
        [SerializeField] private float _throttlePowerSimple = 20;
        [SerializeField] private float _rotationPowerSimple;

        private Rigidbody2D _rigidbody;
        
        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Throttle();
            }
        
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                SteerLeft();
            } 
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                SteerRight();
            }
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        public void Throttle()
        {
            _rigidbody.AddForce(transform.up * _gameSettings.throttlePower, ForceMode2D.Force);
        }

        public void SteerLeft()
        {
            _rigidbody.AddTorque(_gameSettings.rotationPower, ForceMode2D.Force);
        }

        public void SteerRight()
        {
            _rigidbody.AddTorque(-_gameSettings.rotationPower, ForceMode2D.Force);
        }
    }
}
