using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Cor
{
    public class MovingRoad : MonoBehaviour
    {
        [SerializeField] Transform pointEnd;
        [SerializeField] List<GameObject> points;
        [SerializeField] private float scrollSpeed;
        [SerializeField] private float speedMovement;
        Renderer rend;

        private void Start()
        {
            rend = GetComponent<Renderer>();
        }

        private void Update()
        {
            float offset = Time.time * scrollSpeed;
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        }

        public void AddPoint(Transform pos)
        {
            GameObject point = Instantiate(pointEnd.gameObject, pos.position, pos.rotation);
            points.Add(point);
            if(points.Count > 2)
            {
                Destroy(points[0].gameObject);
                points.RemoveAt(0);
            }
            pos.transform.parent = point.transform;
            point.transform.DOLocalMove(new Vector3(pointEnd.position.x, pos.position.y, pointEnd.position.z), speedMovement).SetEase(Ease.Linear).OnComplete(() => pos.transform.parent = null);
        }
    }
}
