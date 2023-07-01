using LeyLines.SceneManagement;

namespace LayLines;

public class GameObject
{
    private readonly List<Component>? _components = new();
    private readonly List<IUpdateable>? _updateableComponents = new();
    private readonly List<IDrawable>? _drawableComponents = new();

    public string Name;
    public string Tag = "";
    public Transform Tranform;

    public Scene Scene;

    #region Constructors

    private GameObject()
    {
        
    }

    #endregion

    #region Lifetime Methods

    public void Awake() => _components?.ForEach(component => component.Awake());
    public void Start() => _components?.ForEach(component => component.Start());
    public void Update() => _updateableComponents?.ForEach(updateable => updateable.Update());
    public void Draw() => _drawableComponents?.ForEach(drawable => drawable.Draw());
    
    
    #endregion

    #region Static Methods

    #region Instantiate

    public static GameObject Instantiate()
    {
        GameObject newObject = new();
        
        newObject.Tranform = (Transform)newObject.AddComponent<Transform>();
        
        newObject.Name = "New GameObject";

        newObject.Scene = SceneManager.ActiveScene;
        SceneManager.ActiveScene.Add(newObject);
        
        return newObject;
    }
    
    public static GameObject Instantiate(Vector3 position)
    {
        GameObject newObject = new();
        
        newObject.Tranform = (Transform)newObject.AddComponent<Transform>();
        newObject.Tranform.Position = position;
        
        newObject.Name = "New GameObject";
        
        newObject.Scene = SceneManager.ActiveScene;
        SceneManager.ActiveScene.Add(newObject);
        
        return newObject;
    }
    
    public static GameObject Instantiate(Vector3 position, GameObject parent)
    {
        throw new NotImplementedException();
    }

    #endregion
    

    public static GameObject Find()
    {
        throw new NotImplementedException();
    }
    
    #endregion

    #region Instance Methods

    public Component AddComponent<T>() where T : Component, new()
    {
        T newComponent = new() { gameObject = this };
        _components?.Add(newComponent);
        if (newComponent is IUpdateable updateableComponent)
            _updateableComponents?.Add(updateableComponent);

        if (newComponent is IDrawable drawableComponent)
            _drawableComponents?.Add(drawableComponent);

        return newComponent;
    }
    
    public void Destroy()
    {
        
    }

    #endregion
    
}