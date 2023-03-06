using UnityEngine;
using DG.Tweening;

namespace BlueStellar.Cor
{
    public class ObstacleFan : MonoBehaviour
    {
        #region Variables

        [SerializeField] Transform fan;
        [SerializeField] Vector3 root;
        [SerializeField] Transform[] points;
        [SerializeField] private int indexMovement;
        [SerializeField] private float speedMovement;
        [SerializeField] private float force;
        [SerializeField] private bool isBackFan;
        [SerializeField] private bool isStatic;

        #endregion

        private void Start()
        {
            fan.DOLocalRotate(root, 0.35f, RotateMode.WorldAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
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

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Character")
            {
                other.GetComponentInParent<CharacterStates>().Push(transform, force, isBackFan);
            }

            if (other.gameObject.tag == "EditorOnly")
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
