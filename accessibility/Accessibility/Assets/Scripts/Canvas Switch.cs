using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSwitch : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Options;

    [SerializeField] private bool isL1;
    [SerializeField] private bool isL2;

    private void update()
    {
        if (isL1)
            {
                Canvas.SetActive(false);
                Options.SetActive(true);
            }
    }
}
