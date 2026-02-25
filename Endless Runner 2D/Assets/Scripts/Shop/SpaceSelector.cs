using UnityEngine;

public class SpaceSelector : MonoBehaviour
{
    public GameObject[] spaceShips;
    int selectedBalls;

    private void Start()
    {
        selectedBalls = PlayerPrefs.GetInt("SelectedShip", 0);
        foreach (GameObject skin in spaceShips)
        {
            skin.SetActive(false);
        }
        spaceShips[selectedBalls].SetActive(true);
    }

    public void ChangeShip(int index)
    {
        spaceShips[selectedBalls].SetActive(false);
        selectedBalls = index;
        spaceShips[selectedBalls].SetActive(true);
        PlayerPrefs.SetInt("SelectedShip", index);
    }
}
