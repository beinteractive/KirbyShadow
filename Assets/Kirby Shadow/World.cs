using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField] private List<GameObject> Prefabs;
    [SerializeField] private List<Material> Materials;
    
    void Start()
    {
        for (var i = 0; i < 100; ++i)
        {
            var g = Instantiate(Prefabs[Random.Range(0, Prefabs.Count)], transform);
            g.transform.localPosition = new Vector3(Random.Range(-3f, 3f), Random.Range(5f, 15f), Random.Range(-3f, 3f));
            g.GetComponent<MeshRenderer>().sharedMaterial = Materials[Random.Range(0, Materials.Count)];
        }

        foreach (var prefab in Prefabs)
        {
            prefab.SetActive(false);
        }
    }
}