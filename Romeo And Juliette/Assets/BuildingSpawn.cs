using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour
{
    public Transform SpawnPosition;

    public void SpawnBuilding(GameObject Buiding)
    {
        Instantiate(Buiding, SpawnPosition.position, Quaternion.identity);
    }

}
