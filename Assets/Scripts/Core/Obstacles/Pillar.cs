using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class Pillar : MonoBehaviour
    {
        [SerializeField] Transform[] points;
        [SerializeField] private float speedMovement;
        [SerializeField] private float speedRotate;

        private int index;
        private bool isActive;

        private void Start()
        {
            LevelManager.Instance.OnLevelStart += ActivityLet;
        }

        private void Update()
        {
            if (!isActive)
                return;

            if(transform.position == points[index].position)
            {
                index++;
                if (index > 1)
                    index = 0;
            }

            transform.position = Vector3.MoveTowards(transform.position, points[index].position, speedMovement * Time.deltaTime);
        }

        private void ActivityLet()
        {
            transform.DORotate(new Vector3(0f, 359f, 0f), speedRotate, RotateMode.WorldAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
            isActive = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Character")
            {
                if (other.GetComponent<Character>() != null)
                    other.GetComponent<Character>().KnockCharacter(transform);
            }
        }
    }
}
