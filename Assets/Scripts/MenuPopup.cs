using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPopup:MonoBehaviour
{
        [SerializeField] private Button replayButton;

        private void Start()
        {
                replayButton.onClick.AddListener(ReloadScene);
        }

        private void ReloadScene()
        {
                GameStatus.Instance.GameState = GameState.StartJump;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}