namespace LayLines;

public class Component
{
    public GameObject gameObject;

    public Transform transform { get; }
    
    #region Lifetime Methods
    
    public virtual void Awake()
    {
        
    }
    public virtual void Start()
    {
        
    }
    #endregion
}