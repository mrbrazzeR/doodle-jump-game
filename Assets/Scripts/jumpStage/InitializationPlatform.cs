using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace jumpStage
{
    public class InitializationPlatform : MonoBehaviour
    {
        [SerializeField] private GameObject normalPlatform;
        [SerializeField] private GameObject springPlatform;
        [SerializeField] private GameObject endPlatform;
        [SerializeField] private GameObject diePlatform;

        [SerializeField] private int numberOfPlatforms;
        [SerializeField] private float levelWidth;
        [SerializeField] private float minY;
        [SerializeField] private float maxY;
        private const int SpringGen = 3;

        private void Start()
        {
            GameStatus.Instance ??= new GameStatus(GameState.StartJump);
            var spawnPosition = new Vector3();

            for (var i = 0; i < numberOfPlatforms; i++)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                var special = Random.Range(1, 15);
                Instantiate(special == SpringGen ? springPlatform : normalPlatform, spawnPosition, Quaternion.identity);
            }

            spawnPosition.x = 0;
            spawnPosition.y += maxY;
            Instantiate(endPlatform, spawnPosition, Quaternion.identity);
            spawnPosition.x = -2;
            spawnPosition.y = -3;
            Instantiate(diePlatform, spawnPosition, Quaternion.identity);
        }
    }
}