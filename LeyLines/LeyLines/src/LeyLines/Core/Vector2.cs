namespace LayLines;

public class Vector2
{
    public float X;
    public float Y;
    public float Magnitude => (X * X + Y * Y);

    #region Constructors

    public Vector2()
    {
        X = 0;
        Y = 0;
    }
    
    public Vector2(float x, float y)
    {
        X = x;
        Y = y;
    }

    #endregion

    #region Operators

    #region Sum operator

    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        a.X += b.X;
        a.Y += b.Y;

        return a;
    }
    
    public static Vector2 operator +(Vector2 a, Vector3 b)
    {
        a.X += b.X;
        a.Y += b.Y;
        
        return a;
    }

    #endregion

    #region Substract Operator

    public static Vector2 operator -(Vector2 a, Vector2 b)
    {
        a.X -= b.X;
        a.Y -= b.Y;
        
        return a;
    }
    
    public static Vector2 operator -(Vector2 a, Vector3 b)
    {
        a.X -= b.X;
        a.Y -= b.Y;
        
        return a;
    }

    #endregion

    #region Multiplication Operator

    public static Vector2 operator *(Vector2 a, Vector2 b)
    {
        a.X /= b.X;
        a.Y /= b.Y;
        
        return a;
    }
    
    public static Vector2 operator *(Vector2 a, Vector3 b)
    {
        a.X *= b.X;
        a.Y *= b.Y;
        
        return a;
    }

    #endregion

    #region Division Operator

    public static Vector2 operator /(Vector2 a, Vector2 b)
    {
        a.X /= b.X;
        a.Y /= b.Y;
        
        return a;
    }
    
    public static Vector2 operator /(Vector2 a, Vector3 b)
    {
        a.X *= b.X;
        a.Y *= b.Y;
        
        return a;
    }

    #endregion

    #endregion
    
    #region Readonly Helpers

    public static readonly Vector2 Zero = new();
    public static readonly Vector2 One = new Vector2(1,1);
    
    public static readonly Vector2 Up = new Vector2(0,1);
    public static readonly Vector2 Down = new Vector2(0,-1);
    public static readonly Vector2 Left = new Vector2(0,-1);
    public static readonly Vector2 Right = new Vector2(0,1);

    #endregion

    #region Static Methods

    public float Distance(Vector2 a, Vector2 b)
    {
        return (a - b).Magnitude;
    }

    #endregion
}