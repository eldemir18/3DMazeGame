using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputReceiver<T>
{
    void SetInputValue(T value);
}
