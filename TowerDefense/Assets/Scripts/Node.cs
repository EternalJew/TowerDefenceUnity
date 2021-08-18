using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] private Color hoverColor;
    public Vector3 positionOffset;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
   
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("cant build there! - TODO: Display on screen");
            return;
        }
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
