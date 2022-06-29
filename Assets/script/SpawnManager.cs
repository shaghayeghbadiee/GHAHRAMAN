using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
public GameObject rock;
void Start()
{
StartCoroutine(SpawnRock());
}

IEnumerator SpawnRock()
{
while(true)
{
  
yield return new WaitForSeconds(Random.Range(4f, 8f));

Vector3 pos = new Vector3(Random.Range(12f, 15f), -2f);

Instantiate(rock, pos, Quaternion.identity);
}
}
}
