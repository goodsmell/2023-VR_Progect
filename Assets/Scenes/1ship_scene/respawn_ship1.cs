using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_ship1 : MonoBehaviour
{
    Transform target;
    int count;

    void Start()
    {
    }

    public void OnFirstHoverEntered()
    {
    }

    public void OnLastHoverExited()
    {

    }

    public void OnHoverEntered()
    {

    }

    public void OnHoverExited()
    {
    }

    public void OnFirstSelectEntered()
    {

    }

    public void OnLastSelectExited()
    {

    }

    public void OnSelectEntered()
    {
    }

    public void OnSelectExited(GameObject Fishingrods)
    {
        target = Fishingrods.GetComponent<Transform>();
        target.position = new Vector3(2.0f, 1.0f, -0.4f);
        target.rotation = Quaternion.Euler(-40, 90, -90);
    }

    public void OnActivated()
    {

    }

    public void OnDeactivated()
    {

    }
}
