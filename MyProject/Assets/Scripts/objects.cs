using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
    [SerializeField] GameObject[] astreoid;
    private float spawnS = 1.5f;
    [SerializeField] float maxX;
    [SerializeField] float minX;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            var wanted = Random.Range(minX, maxX);
            var position = new Vector3(wanted, transform.position.y,1);
            GameObject gameObject = Instantiate(astreoid[Random.Range(0, astreoid.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(spawnS);
            Destroy(gameObject, 3f);
        }
    } 
}
