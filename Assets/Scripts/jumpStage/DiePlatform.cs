using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jumpStage
{
    public class DiePlatform : MonoBehaviour
    {
        public void SubScribe(NormalPlatform normalPlatform)
        {
            normalPlatform.OnPublish += OnNotifyReceived;
        }

        public void UnSubScribe(NormalPlatform normalPlatform)
        {
            normalPlatform.OnPublish -= OnNotifyReceived;
        }

        private void OnNotifyReceived(Transform trans)
        {
            transform.position = trans.position;
        }

        private void Start()
        {
            GameStatus.Instance ??= new GameStatus();
        }
        
        private void Update()
        {
            if (GameStatus.Instance.GameState == GameState.EndJump)
            {
                gameObject.SetActive(false);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.collider.CompareTag("Player"))
            {
                GameStatus.Instance.GameState = GameState.Lose;
               
            }
        }
    }
}