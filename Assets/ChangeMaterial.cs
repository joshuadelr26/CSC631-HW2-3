using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject Wall1, Wall2, Wall3, Wall4;
    public Button Button1, Button2;
    public Material Tile, Wood;
    void Start()
    {
        // calls the Function specified when button is clicked
        Button1.onClick.AddListener(ChangeToTile);
        Button2.onClick.AddListener(ChangeToWood);
    }

    void ChangeToTile()
    {
        Wall1.GetComponent<Renderer>().material = Tile;
        Wall2.GetComponent<Renderer>().material = Tile;
        Wall3.GetComponent<Renderer>().material = Tile;
        Wall4.GetComponent<Renderer>().material = Tile;
        Debug.Log("Tile Material Change Button Clicked.");
    }

    void ChangeToWood()
    {
        Wall1.GetComponent<Renderer>().material = Wood;
        Wall2.GetComponent<Renderer>().material = Wood;
        Wall3.GetComponent<Renderer>().material = Wood;
        Wall4.GetComponent<Renderer>().material = Wood;
        Debug.Log("Wood Material Change Button Clicked.");
    }
}
