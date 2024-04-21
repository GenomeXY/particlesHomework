using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePrefabCreator : MonoBehaviour
{
    public GameObject ParticlesPrefab;
    public Transform Spawn;

    public void Create()
    {
        Instantiate(ParticlesPrefab, Spawn.position, Spawn.rotation);
    }
}
