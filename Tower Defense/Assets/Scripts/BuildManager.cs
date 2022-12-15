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
    public GameObject missileLauncherPrefab;
    public GameObject rocketSharkPrefab;

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;
    private Node selectedNode;

    public bool canBuild { get { return turretToBuild != null; }  }
    public bool hasMoney { get { return PlayerStats.money >= turretToBuild.cost; }  }

    public void BuildTurretOn(Node node)
    {

        if(PlayerStats.money < turretToBuild.cost)
        {
            Debug.Log("Not enough money");
            return;
        }

        PlayerStats.money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPoisition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPoisition(), Quaternion.identity);
        Destroy(effect, 1f);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        selectedNode = null;
    }
    
    public void SelectNode(Node node)
    {
        selectedNode = node;
        turretToBuild = null;
    }
}
