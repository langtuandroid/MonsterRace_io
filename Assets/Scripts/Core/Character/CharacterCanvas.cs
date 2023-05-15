using UnityEngine;

namespace Core
{
    public class CharacterCanvas : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Transform targetCharacter;
        [SerializeField] private Transform targetMonster;

        private Transform _target;
        private Transform _transform;

        #endregion

        private void Start()
        {
            _transform = GetComponent<Transform>();
            _transform.parent = null;
            _target = targetCharacter;
        }

        private void LateUpdate()
        {
            if(_target != null)
                transform.position = _target.position;
        }

        public void SetMonsterTarget()
        {
            _target = targetMonster;
        }
    }
}
