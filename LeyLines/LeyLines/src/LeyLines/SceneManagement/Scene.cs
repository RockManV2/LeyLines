using LayLines;

namespace LeyLines.SceneManagement;

public class Scene
{
    private List<GameObject>? _sceneObjects;

    #region Lifetime Methods
    
    public void Awake() => _sceneObjects?.ForEach(gameObject => gameObject.Awake());
    public void Start() => _sceneObjects?.ForEach(gameObject => gameObject.Start());
    public void Update() => _sceneObjects?.ForEach(gameObject => gameObject.Update());
    public void Draw() => _sceneObjects?.ForEach(gameObject => gameObject.Draw());
    
    #endregion

    #region Instance Methods

    public void Add(GameObject newObject)
    {
        _sceneObjects.Add(newObject);
    }

    public void Remove(GameObject gameObject)
    {
        _sceneObjects.Remove(gameObject);
    }

    #endregion
    
}