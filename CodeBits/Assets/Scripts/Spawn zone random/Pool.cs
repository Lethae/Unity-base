using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour {

    public int m_PoolSize;
    public GameObject m_PrefabToPool1;
    public GameObject m_PrefabToPool2;
    private GameObject[] m_pool;


	void Start () {
        m_pool = new GameObject[m_PoolSize];

        for (int i = 0; i < Mathf.RoundToInt(m_PoolSize); i += 2)
        {
            var a_GO = Instantiate(m_PrefabToPool1);
            m_pool[i] = a_GO;
            a_GO.SetActive(false);
            var a_GO2 = Instantiate(m_PrefabToPool2);
            m_pool[i+1] = a_GO2;
            a_GO2.SetActive(false);

        }

    }
	
    public GameObject GetAvailableObject()
    {
        for (int i = 0; i < m_PoolSize; i++)
        {
            if (m_pool[i].activeInHierarchy == false)
                return m_pool[i];
        }
        return null;
    }

    public void ReturnToPool(GameObject a_item, Vector3 a_position)
    {
        a_item.SetActive(false);
        var a_rgbd = a_item.GetComponent<Rigidbody>();
        a_item.transform.position = a_position;
        a_rgbd.velocity = new Vector3(0f, 0f, 0f);

    }
}
