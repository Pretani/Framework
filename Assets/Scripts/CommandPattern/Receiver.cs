using UnityEngine;

/// <summary>
/// Receiver that knows how to perform the desired operation
/// </summary>
namespace DesignPatterns.Structural.Command
{
    public class Receiver
    {
        public void DoAction()
        {
            Debug.Log("Receiver Do Action");
        }
    }
}
