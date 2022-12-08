using UnityEngine;

public class BuildManager : MonoBehaviour
{


    #region Singleton
    public static BuildManager instance;
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("A BuildManager is already here");
            return;
        }
        instance = this;
    }
    #endregion

    public GameObject standardTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        Debug.Log("turretToBuild" + turretToBuild);
        return turretToBuild;

    }
   
    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
