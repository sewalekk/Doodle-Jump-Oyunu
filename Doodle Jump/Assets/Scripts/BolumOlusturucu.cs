using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumOlusturucu : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformSayisi = 200;

    void Start()
    {
        LevelUret();
    }
    //en sol -1.9f en sað 1.9f
    void LevelUret()
    {
        Vector2 platformVektor=new Vector2();
        for (int i=0; i<platformSayisi;i++)
        {
            GameObject tempPlatform= Instantiate(platformPrefab);
            float xPozisyonu = Random.Range(-1.9f, 1.9f);
            float yPozisyonu = Random.Range(1.6f,2);
            platformVektor.x = xPozisyonu;
            platformVektor.y+= yPozisyonu;
            tempPlatform.transform.position = platformVektor;

        }
    }


}

