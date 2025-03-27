using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
 


    public static List<pooledObjectInfo> objectPools = new List<pooledObjectInfo>();

    public static GameObject SpawnObject(GameObject objectToSpawn, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        pooledObjectInfo pool = objectPools.Find(p => p.lookupString == objectToSpawn.name);

        if (pool == null)
        {
            pool = new pooledObjectInfo() { lookupString = objectToSpawn.name };

            objectPools.Add(pool);

        }
        GameObject spawnableObj = null;
        foreach (GameObject obj in pool.inactiveObjects)
        {
            if (obj != null)
            {
                spawnableObj = obj;
                break;
            }
        
        }
        if (spawnableObj == null)
        {
            spawnableObj = Instantiate(objectToSpawn, spawnPosition, spawnRotation);

        }
        else
        {
            spawnableObj.transform.position = spawnPosition;
            spawnableObj.transform.rotation = spawnRotation;
            pool.inactiveObjects.Remove(spawnableObj);
            spawnableObj.SetActive(true);
        
        }
        return spawnableObj;
    }

    public static void ReturnObjectToPool(GameObject obj)
    {

        string goName = obj.name.Substring(0, obj.name.Length - 7);  
        pooledObjectInfo pool = objectPools.Find(p => p.lookupString == goName);
        if (obj == null)
        {
            Debug.Log("Queee");

        }
        else
        {
            obj.SetActive(false);
            pool.inactiveObjects.Add(obj);

        }

    }

    

    public class pooledObjectInfo
    {

        public string lookupString;
        public List<GameObject> inactiveObjects = new List<GameObject>();

          
    
    }

   
}
