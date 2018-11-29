using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class PlayerActions : PlayerActionSet {

    public PlayerAction Left;

    public PlayerAction Right;

    public PlayerAction Up;

    public PlayerAction Down;

    public PlayerOneAxisAction Horizontal;

    public PlayerOneAxisAction Vertical;

    public PlayerAction Interact;

    public PlayerActions()
    {
        Left = CreatePlayerAction("Left");
        Right = CreatePlayerAction("Right");
        Up = CreatePlayerAction("Up");
        Down = CreatePlayerAction("Down");
        Horizontal = CreateOneAxisPlayerAction(Left, Right);
        Vertical = CreateOneAxisPlayerAction(Up, Down);
        Interact = CreatePlayerAction("Interact");
    }

}
