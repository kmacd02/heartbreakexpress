using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class MenuFunctions : MonoBehaviour
{
    [Header("How To")]
    [SerializeField]
    private VisualTreeAsset HowToMenu;
    private VisualElement Tutorial;
    
    [Header("UI Volume Control")]
    [SerializeField]
    private VisualTreeAsset VolumeMenu;
    private VisualElement VolumeStuff;
    
    
    
    // Initializing Main Menu Buttons
    private UIDocument doc;
    public Button PlayButton;
    public Button OptionsButton;
    public Button QuitButton;
    public Button MenuButton;
    public Button HowToButton;
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
