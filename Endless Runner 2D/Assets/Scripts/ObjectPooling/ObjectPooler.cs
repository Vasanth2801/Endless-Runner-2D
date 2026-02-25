using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class ObjectPool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public ObjectPool[] pools;
    public Dictionary<string, Queue<GameObject>> poolOfDictionary;

    void Start()
    {
        poolOfDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(ObjectPool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolOfDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPools(string tag,Vector3 position, Quaternion rotation)
    {
        GameObject objectToSpawn = poolOfDictionary[tag].Dequeue();
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;
        poolOfDictionary[tag].Enqueue(objectToSpawn);
        return objectToSpawn;
    }
}