using UnityEngine;

namespace PlayKing.Cor
{
    [RequireComponent(typeof(Rigidbody))]
    public class MonsterBall : MonoBehaviour
    {
        [SerializeField] MeshRenderer meshRenderer;
        [SerializeField] Material[] materials;
        [SerializeField] Rigidbody _rb;
        [SerializeField] private float force;
        [SerializeField] private bool isHeadBall;

        CharacterSettings _characterSettings;
        MonsterSpine _monsterSpine;

        public bool IsHeadBall()
        {
            return isHeadBall;
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _characterSettings = GetComponentInParent<CharacterSettings>();
            _monsterSpine = GetComponentInParent<MonsterSpine>();
            _monsterSpine.AddBallsToSpine(this);
            if (!isHeadBall)
                SwitchColor();
        }

        public void Explosion(Vector3 dir)
        {
            transform.parent = null;
            _rb.isKinematic = false;
            _rb.AddForce(dir * force, ForceMode.Impulse);
        }

        private void SwitchColor()
        {
            switch (_characterSettings.Type())
            {
                case CharacterColorType.Blue:
                    meshRenderer.material = materials[0];
                    break;
                case CharacterColorType.Green:
                    meshRenderer.material = materials[1];
                    break;
                case CharacterColorType.Yellow:
                    meshRenderer.material = materials[2];
                    break;
                case CharacterColorType.Violet:
                    meshRenderer.material = materials[3];
                    break;
                case CharacterColorType.Red:
                    meshRenderer.material = materials[4];
                    break;
                case CharacterColorType.Purple:
                    meshRenderer.material = materials[5];
                    break;
            }
        }
    }
}
