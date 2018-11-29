using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{ //Appliqué sur la plateforme, pour qu'elle fasse spawn les objets dessus

    private float m_LLimit; //Point Left de la platform
    private float m_RLimit; //Right 
    private float m_BLimit; //Bot  
    private float m_TLimit; //Top

    public int m_itemsActive = 0;

    private Pool m_pool;
    private GameManager m_gameManager;

    private bool m_initializeSpawn = true;
    public float m_TimeToSpawn = 3f;

    void Start()
    {

        m_pool = FindObjectOfType<Pool>();
        m_gameManager = FindObjectOfType<GameManager>();
        m_LLimit = transform.position.x - 0.5f * transform.lossyScale.x + m_pool.m_PrefabToPool1.transform.lossyScale.x;
        m_RLimit = transform.position.x + 0.5f * transform.lossyScale.x - m_pool.m_PrefabToPool1.transform.lossyScale.x;
        m_BLimit = transform.position.z - 0.5f * transform.lossyScale.z + m_pool.m_PrefabToPool1.transform.lossyScale.z;
        m_TLimit = transform.position.z + 0.5f * transform.lossyScale.z - m_pool.m_PrefabToPool1.transform.lossyScale.z;
        StartCoroutine("SpawnItemTimed");

    }


    void Update()
    {
        InitializeSpawn();
    }

    void InitializeSpawn()
    {
        if (m_initializeSpawn == true)
        {
            for (int i = 0; i < 8; i++)
            {
                SpawnItem();
            }
            m_initializeSpawn = false;
        }

    }

    void SpawnItem()
    {
        var a_item = m_pool.GetAvailableObject();
        a_item.transform.position = new Vector3(Random.Range(m_LLimit, m_RLimit), 5f, Random.Range(m_BLimit, m_TLimit));
        a_item.SetActive(true);
        m_itemsActive += 1;
    }


    IEnumerator SpawnItemTimed()
    {
        yield return new WaitForSeconds(m_TimeToSpawn);
        if (m_itemsActive < m_pool.m_PoolSize)
        {
            SpawnItem();
        }
        StartCoroutine("SpawnItemTimed");
    }

}
