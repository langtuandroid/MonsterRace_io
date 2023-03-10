using UnityEngine;
using UnityEngine.Pool;

public class BallsPool: MonoBehaviour
{
    public ObjectPool<GameObject> myPool;

    public void DestroyPoolObject()
    {
        myPool.Release(gameObject);
    }
}