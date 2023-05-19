using System;
using UnityEngine;

namespace jumpStage
{
    public class NormalPlatform : MonoBehaviour
    {
        [SerializeField] private float jumpHeight;
        private Camera _camera;
        
        public delegate void Notify(Transform transform);
        public event Notify OnPublish;
        [SerializeField] private DiePlatform diePlatform;

        private void Start()
        {
            _camera = Camera.main;
            diePlatform.SubScribe(this);
        }

        private void Update()
        {
            if (_camera != null && transform.position.y < _camera.ViewportToWorldPoint(new Vector2(0, 0)).y)
            { 
                OnPublish?.Invoke(transform);
                Destroy(gameObject);
            }
        }

        private void OnDestroy()
        {
            diePlatform.UnSubScribe(this);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.collider.CompareTag("Player"))
            {
                var rb = other.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    var velocity = rb.velocity;
                    velocity.y = jumpHeight;
                    rb.velocity = velocity;
                }
            }
        }
    }
}