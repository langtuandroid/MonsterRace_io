using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class PointerManager : MonoBehaviour
    {
        #region Singelton

        public static PointerManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        #endregion

        [SerializeField] private Transform pointSpawn;
        [SerializeField] private PointerArrow pointerPrefab;
        [SerializeField] private PlayerMovement playerTransform;
        [SerializeField] private Camera _camera;
        private bool _canShow;

        private Dictionary<BotPointer, PointerArrow> _dictionary = new Dictionary<BotPointer, PointerArrow>();

        private void Start()
        {
            playerTransform = FindObjectOfType<PlayerMovement>();
            LevelManager.Instance.OnLevelStart += ShowedPointer;
        }

        public void AddToList(BotPointer enemyPointer)
        {
            PointerArrow newPointer = Instantiate(pointerPrefab, pointSpawn);
            _dictionary.Add(enemyPointer, newPointer);
        }

        public void RemoveFromList(BotPointer enemyPointer)
        {
            Destroy(_dictionary[enemyPointer].gameObject);
            _dictionary.Remove(enemyPointer);
        }

        private void LateUpdate()
        {
            if (!_canShow)
                return;

            Plane[] planes = GeometryUtility.CalculateFrustumPlanes(_camera);

            foreach (var kvp in _dictionary)
            {
                BotPointer enemyPointer = kvp.Key;
                PointerArrow pointerIcon = kvp.Value;

                Vector3 toEnemy = enemyPointer.transform.position - playerTransform.transform.position;
                Ray ray = new Ray(playerTransform.transform.position, toEnemy);
                //Debug.DrawRay(playerTransform.transform.position, toEnemy);
                
                var rayMinDistance = Mathf.Infinity;
                var index = 0;

                for (int p = 0; p < 4; p++)
                {
                    if (planes[p].Raycast(ray, out float distance))
                    {
                        if (distance < rayMinDistance)
                        {
                            rayMinDistance = distance;
                            index = p;
                        }
                    }
                }

                rayMinDistance = Mathf.Clamp(rayMinDistance, 0, toEnemy.magnitude);
                Vector3 worldPosition = ray.GetPoint(rayMinDistance);
                Vector3 position = _camera.WorldToScreenPoint(worldPosition);
                Quaternion rotation = GetIconRotation(index);

                if (toEnemy.magnitude > rayMinDistance)
                {
                    pointerIcon.Show();
                }
                else
                {
                    pointerIcon.Hide();
                }

                pointerIcon.SetIconPosition(position, rotation);
            }
        }

        private void ShowedPointer() => _canShow = true;

        private Quaternion GetIconRotation(int planeIndex)
        {
            return planeIndex switch
            {
                0 => Quaternion.Euler(0f, 0f, 90f),
                1 => Quaternion.Euler(0f, 0f, -90f),
                2 => Quaternion.Euler(0f, 0f, 180),
                3 => Quaternion.Euler(0f, 0f, 0f),
                _ => Quaternion.identity
            };
        }
    }
}
