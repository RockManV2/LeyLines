namespace LayLines;

public class Vector3
{
    public float X;
    public float Y;
    public float Z;
    
    public float Magnitude => (X * X + Y * Y + Z * Z);
    
    #region Constructors

    public Vector3()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }
    
    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    #endregion

    #region Operators

    #region Sum operator

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        a.X += b.X;
        a.Y += b.Y;
        a.Z += b.Z;
        
        return a;
    }
    
    public static Vector3 operator +(Vector3 a, Vector2 b)
    {
        a.X += b.X;
        a.Y += b.Y;
        
        return a;
    }

    #endregion

    #region Substract Operator

    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        a.X -= b.X;
        a.Y -= b.Y;
        a.Z -= b.Z;
        
        return a;
    }
    
    public static Vector3 operator -(Vector3 a, Vector2 b)
    {
        a.X -= b.X;
        a.Y -= b.Y;
        
        return a;
    }

    #endregion

    #region Multiplication Operator

    public static Vector3 operator *(Vector3 a, Vector3 b)
    {
        a.X /= b.X;
        a.Y /= b.Y;
        a.Z /= b.Z;
        
        return a;
    }
    
    public static Vector3 operator *(Vector3 a, Vector2 b)
    {
        a.X *= b.X;
        a.Y *= b.Y;
        
        return a;
    }

    #endregion

    #region Division Operator

    public static Vector3 operator /(Vector3 a, Vector3 b)
    {
        a.X /= b.X;
        a.Y /= b.Y;
        a.Z /= b.Z;
        
        return a;
    }
    
    public static Vector3 operator /(Vector3 a, Vector2 b)
    {
        a.X *= b.X;
        a.Y *= b.Y;
        
        return a;
    }

    #endregion

    #endregion
    
    #region Readonly Helpers

    public static readonly Vector3 Zero = new();
    public static readonly Vector3 One = new Vector3(1,1,1);
    
    public static readonly Vector3 Up = new Vector3(0,1, 0);
    public static readonly Vector3 Down = new Vector3(0,-1, 0);
    public static readonly Vector3 Left = new Vector3(0,-1, 0);
    public static readonly Vector3 Right = new Vector3(0,1, 0);

    #endregion
    
    #region Static Methods

    public float Distance(Vector3 a, Vector3 b)
    {
        return (a - b).Magnitude;
    }

    #endregion
}