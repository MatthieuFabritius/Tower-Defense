using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;

    private Color startColor;
    private GameObject turret;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Place already taken!");
            return;
        }
        else
        {

        }
        Debug.Log("TurretToBuild : " + turretToBuild);
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }


    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
