using UnityEngine;

public class UI_Purpose : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject secondPanel;
    
    void Start()
    {
        secondPanel.SetActive(false);
    }

    
    void Update()
    {
        
    }
    public void NextButton()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }
    public void StartButton()
    {
        secondPanel.SetActive(false);
    }
    
}
