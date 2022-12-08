using UnityEngine;

public class Shop : MonoBehaviour
{

    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard turred Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLauncher()
    {
        Debug.Log("Missile Laucher Selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }
}
