using UnityEngine.Events;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public UnityEvent menuDidAppear = new UnityEvent();
    public UnityEvent menuWillDisappear = new UnityEvent();
}