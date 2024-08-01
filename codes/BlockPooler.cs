using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPooler : MonoBehaviour
{
    public GameObject pooledObject;
    public int numofObject;
    private List<GameObject> gameObjects;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = new List<GameObject>();
        for(int i=0; i<numofObject; i++){
            GameObject gameObject = Instantiate(pooledObject);
            gameObject.SetActive(false);
            gameObjects.Add(gameObject);
        }
        
    }
    
    public GameObject GetPooledGameObject(){
        foreach(GameObject gameObject in gameObjects){
            if(!gameObject.activeInHierarchy){
                return gameObject;
            }
        }

        GameObject gameObj = Instantiate(pooledObject);
        gameObject.SetActive(false);
        gameObjects.Add(gameObj);
        return gameObj;
    }

}
