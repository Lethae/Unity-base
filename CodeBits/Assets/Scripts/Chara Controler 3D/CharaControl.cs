using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class CharaControl : MonoBehaviour {

    public float m_Speed;
    //private Animator m_animator;

    private void Start()
    {
        //m_animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameManager.Instance.m_Actions.Horizontal.Value != 0f)  //input horizontal movement
        {
            this.transform.position -= Vector3.left * m_Speed * Time.deltaTime * GameManager.Instance.m_Actions.Horizontal.Value;   //move horizontal
            this.transform.eulerAngles = new Vector3(0, Mathf.Atan2(GameManager.Instance.m_Actions.Vertical.Value, GameManager.Instance.m_Actions.Horizontal.Value) * 180 / Mathf.PI - 90, 0);  //rotate on itself
            
        }

        if (GameManager.Instance.m_Actions.Vertical.Value != 0f) //input vertical movement
        {
            this.transform.position -= Vector3.forward * m_Speed * Time.deltaTime * GameManager.Instance.m_Actions.Vertical.Value; //move vertical
            this.transform.eulerAngles = new Vector3(0, Mathf.Atan2(GameManager.Instance.m_Actions.Vertical.Value, GameManager.Instance.m_Actions.Horizontal.Value) * 180 / Mathf.PI - 90, 0);  //rotate on itself
            
        }

        if (GameManager.Instance.m_Actions.Interact.WasPressed) //input action button
        {
            //interact
        }

        Animation();
    } //update

    void Animation()
    {
        //m_animator.SetFloat("MoveSpeed", Mathf.Abs(GameManager.Instance.m_Actions.Horizontal.Value)+ Mathf.Abs(GameManager.Instance.m_Actions.Vertical.Value));
    }

}
