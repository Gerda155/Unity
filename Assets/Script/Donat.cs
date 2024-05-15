using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Donat : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float spawnInterval = 1.0f;
    float maxPos, minPos;
    Transform bakeryTransf;

    private void Start()
    {
        bakeryTransf = GetComponent<Transform>();
    }
    public void Bake(bool state)
    {
        if (state) StartCoroutine(Spawn());
        else StopAllCoroutines();
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            minPos = bakeryTransf.position.x - 40;
            maxPos = bakeryTransf.position.x + 40;
            var value = UnityEngine.Random.Range(minPos, maxPos);
            var pos = new Vector2(value, transform.position.y);
            GameObject donut = Instantiate(donutPrefabs[UnityEngine.Random.Range(0, donutPrefabs.Length)], pos, Quaternion.identity, bakeryTransf);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
