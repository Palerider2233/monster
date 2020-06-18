using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratEenemies : MonoBehaviour
{
    public GameObject theEnemy;
    public ini xPos;
    public ini zPos;
    public ini enemyCount;

    void Start ();
    {
        
    }
    IEnumerator EnermyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(1,50);
            zPos = Random.Range(1,31);
            Instaniate(theEnemy,new Vector3(xPos,0,zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount +=1;
        }
    }
}