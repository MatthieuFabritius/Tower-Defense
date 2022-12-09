using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncherTurret;


    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard turred Selected");
        buildManager.SelectTurretToBuild(buildManager.standardTurret);
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Laucher Selected");
        buildManager.SelectTurretToBuild(buildManager.missileLauncherTurret);
    }
}
