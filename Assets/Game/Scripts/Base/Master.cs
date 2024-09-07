using UnityEngine;
using UnityEngine.SceneManagement;

public class Master : MonoBehaviour
{
    public static Master Instance;
    public MainSceneManager MainSceneManager => _mainSceneManager;
    public UIController UIController => _uIController;

    private MainSceneManager _mainSceneManager;
    [SerializeField] private UIController _uIController;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }

    private void Start()
    {
        _mainSceneManager = new MainSceneManager();
        _mainSceneManager.LoadSceneByName(Enums.Scene.MainMenu);
    }
}
