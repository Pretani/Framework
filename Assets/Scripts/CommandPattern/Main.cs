using UnityEngine;
using DesignPatterns.Structural.Command;

/// <summary>
/// Example script that demonstrates how the Command Pattern can be used
/// Attach this script to a gameobject in a scene
/// </summary>
public class Main : MonoBehaviour
{
    private readonly Receiver _receiver = new Receiver();
    private Invoker _invoker = new Invoker();
    private Command _command;

	private void Start ()
    {
        _command = new ConcreteCommand(_receiver);
        _invoker.SetCommand(_command);
        _invoker.ExecuteCommand();
    }
}
