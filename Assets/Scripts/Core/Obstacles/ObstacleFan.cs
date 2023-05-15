using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class ObstacleFan : MonoBehaviour
    {
        #region Variables

        [SerializeField] Transform fan;
        [SerializeField] Transform point;
        [SerializeField] Vector3 root;
        [SerializeField] Transform[] points;
        [SerializeField] private int indexMovement;
        [SerializeField] private float speedMovement;
        [SerializeField] private float minForce;
        [SerializeField] private float maxForce;
        [SerializeField] private bool isBackFan;
        [SerializeField] private bool isStatic;

        #endregion

        private void Start()
        {
            fan.DOLocalRotate(root, 0.7f, RotateMode.WorldAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
        }

        private void FixedUpdate()
        {
            if (isStatic)
                return;

            if (transform.position == points[indexMovement].position)
            {
                indexMovement++;
                if (indexMovement >= points.Length)
                    indexMovement = 0;
            }
        }

        private void Update()
        {
            if (isStatic)
                return;

            transform.position = Vector3.MoveTowards(transform.position, points[indexMovement].position, speedMovement);
        }

        public float testDist;

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Character"))
            {
                testDist = Vector3.Distance(transform.position, other.transform.position);
                if(testDist > 6.8f)
                    other.GetComponentInParent<CharacterStates>().Push(point, maxForce);
                if (testDist <= 6.8f)
                    other.GetComponentInParent<CharacterStates>().Push(point, minForce);
            }

            if (other.CompareTag("EditorOnly"))
            {
                if (!isBackFan)
                {
                    isBackFan = true;
                    return; 
                }

                if (isBackFan) 
                { 
                    isBackFan = false;
                }
            }
        }
    }
}
