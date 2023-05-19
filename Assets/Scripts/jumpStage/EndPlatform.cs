using System;
using System.Collections;
using UnityEngine;

namespace jumpStage
{
    public class EndPlatform : MonoBehaviour
    {
        private Rigidbody2D _playerRigidBody;


        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.collider.CompareTag("Player"))
            {
                _playerRigidBody = other.gameObject.GetComponent<Rigidbody2D>();
                StartCoroutine(EndPhase());
            }
        }

        private IEnumerator EndPhase()
        {
            yield return new WaitForSeconds(0.5f);
            _playerRigidBody.velocity = Vector2.zero;
            _playerRigidBody.angularVelocity = 0;
            _playerRigidBody.gravityScale = 0;
            GameStatus.Instance.GameState = GameState.StartFlappy;
        }
    }
}