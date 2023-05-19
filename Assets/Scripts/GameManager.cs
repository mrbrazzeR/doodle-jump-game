using UnityEngine;

public class GameManager:MonoBehaviour
{
        [SerializeField] private MenuPopup menuPopup;

        private void Start()
        {
                menuPopup.gameObject.SetActive(false);
        }

        private void LateUpdate()
        {
                if (GameStatus.Instance.GameState == GameState.Lose)
                {
                        menuPopup.gameObject.SetActive(true);
                }
               
        }
}