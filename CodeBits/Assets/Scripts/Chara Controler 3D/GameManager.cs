using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public PlayerActions m_Actions;

    void Awake () {
        Instance = this;
        initializeActions();
	}

    private void initializeActions()
    {
        m_Actions = new PlayerActions();

        m_Actions.Left.AddDefaultBinding(Key.LeftArrow);
        m_Actions.Left.AddDefaultBinding(Key.Q);
        m_Actions.Left.AddDefaultBinding(Key.A);
        m_Actions.Left.AddDefaultBinding(InputControlType.LeftStickLeft);
        m_Actions.Left.AddDefaultBinding(InputControlType.RightStickLeft);
        m_Actions.Left.AddDefaultBinding(InputControlType.DPadLeft);

        m_Actions.Right.AddDefaultBinding(Key.RightArrow);
        m_Actions.Right.AddDefaultBinding(Key.D);
        m_Actions.Right.AddDefaultBinding(InputControlType.LeftStickRight);
        m_Actions.Right.AddDefaultBinding(InputControlType.RightStickRight);
        m_Actions.Right.AddDefaultBinding(InputControlType.DPadRight);

        m_Actions.Up.AddDefaultBinding(Key.UpArrow);
        m_Actions.Up.AddDefaultBinding(Key.Z);
        m_Actions.Up.AddDefaultBinding(Key.W);
        m_Actions.Up.AddDefaultBinding(InputControlType.LeftStickUp);
        m_Actions.Up.AddDefaultBinding(InputControlType.RightStickUp);
        m_Actions.Up.AddDefaultBinding(InputControlType.DPadUp);

        m_Actions.Down.AddDefaultBinding(Key.DownArrow);
        m_Actions.Down.AddDefaultBinding(Key.S);
        m_Actions.Down.AddDefaultBinding(InputControlType.LeftStickDown);
        m_Actions.Down.AddDefaultBinding(InputControlType.RightStickDown);
        m_Actions.Down.AddDefaultBinding(InputControlType.DPadDown);

        m_Actions.Interact.AddDefaultBinding(Key.Space);
        m_Actions.Interact.AddDefaultBinding(InputControlType.Action1);
    }
}
