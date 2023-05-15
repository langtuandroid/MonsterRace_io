using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Core
{
    public class MovingRoad : MonoBehaviour
    {
        [SerializeField] private Transform pointEnd;
        [SerializeField] private List<GameObject> points;
        [SerializeField] private float scrollSpeed;
        [SerializeField] private float speedMovement;
        private Renderer _renderer;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            var offset = Time.time * scrollSpeed;
            _renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
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
