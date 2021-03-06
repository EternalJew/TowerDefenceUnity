using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
   public static BuildManager instance;
   void Awake()
   {
       if (instance != null)
       {
           Debug.LogError("More than one build manager");
           return;
       }
       instance = this;
   }

   [SerializeField] private GameObject standardTurretPrefab;
   void Start()
   {
       turretToBuild = standardTurretPrefab;
   }
   private GameObject turretToBuild;
   public GameObject GetTurretToBuild()
   {
       return turretToBuild;
   }
}
