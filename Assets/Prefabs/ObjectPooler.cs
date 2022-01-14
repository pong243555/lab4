using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    public bool shouldExpand = true;
    void Awake()
    {
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject(string v)
    {
        if (shouldExpand) {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            return obj;
            } else {
            return null;
        }


    // Update is called once per frame
    void Update()
    {

    }
    }
    }