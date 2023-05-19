using UnityEngine;

namespace FlappyStage
{
    public class InitializationFlappy: MonoBehaviour
    {
        [SerializeField] private int numberOfPlatforms;
        [SerializeField] private float levelWidth;
        [SerializeField] private float minY;
        [SerializeField] private float maxY;
    }
}