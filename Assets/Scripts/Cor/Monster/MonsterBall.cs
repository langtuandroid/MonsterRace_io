using UnityEngine;

namespace PlayKing.Cor
{
    [RequireComponent(typeof(Rigidbody))]
    public class MonsterBall : MonoBehaviour
    {
        public Transform point;

        [SerializeField] MeshRenderer meshRenderer;
        [SerializeField] Material[] materials;
        [SerializeField] private float force;

        [SerializeField] Rigidbody _rb;
        public bool isHead;
        CharacterSettings characterSettings;
        CharacterMonster _characterMonster;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            characterSettings = GetComponentInParent<CharacterSettings>();
            _characterMonster = GetComponentInParent<CharacterMonster>();
            _characterMonster.AddMonsterBall(this);
            if (!isHead)
            {
                SwitchColor();
            }
        }

        public void Explosion(Vector3 dir)
        {
            transform.parent = null;
            _rb.isKinematic = false;
            _rb.AddForce(dir * force, ForceMode.Impulse);
        }

        private void SwitchColor()
        {
            switch (characterSettings.Type())
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
