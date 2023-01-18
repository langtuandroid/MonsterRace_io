using UnityEngine;

namespace PlayKing.Cor.FPS
{
    public class FPSController : MonoBehaviour
    {
        [SerializeField] private int targetFrames;

        private void Start()
        {
            Application.targetFrameRate = targetFrames;
        }
    }
}
