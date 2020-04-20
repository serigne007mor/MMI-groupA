using UnityEngine;
using System.Collections;

public class spaw : MonoBehaviour
{
    // Mole Prefab
    public GameObject cube;

    // Spawn Interval
    public int intervalMin = 2;
    public int intervalMax = 10;

    // Use this for initialization
    void Start()
    {
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }

    void Spawn()
    {
        // Spawn the mole
        GameObject g = (GameObject)Instantiate(cube, transform.position, Quaternion.identity);

        // Next Spawn
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
}