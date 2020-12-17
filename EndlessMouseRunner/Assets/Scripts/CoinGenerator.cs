using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public ObjectPooler coinPool;
    public float distanceBetweenCoins;
    // Start is called before the first frame update

    public void SpawnCoins(Vector3 startPoisition)
    {
        GameObject coin1 = coinPool.GetPooledObject();
        coin1.transform.position = startPoisition;
        coin1.SetActive(true);

        GameObject coin2 = coinPool.GetPooledObject();
        coin1.transform.position = new Vector3(startPoisition.x - distanceBetweenCoins, startPoisition.y, startPoisition.z);
        coin2.SetActive(true);

        GameObject coin3 = coinPool.GetPooledObject();
        coin1.transform.position = startPoisition;
        coin1.SetActive(true);
    }
}