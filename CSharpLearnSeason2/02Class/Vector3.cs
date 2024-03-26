namespace _02Class;

public class Vector3
{
    private float _x;
    private float _y;
    private float _z;


    public float X
    {
        get => _x;
        set => _x = value;
    }

    public float Y
    {
        get => _y;
        set => _y = value;
    }

    public float Z
    {
        get => _z;
        set => _z = value;
    }


    public double Distance()
    {
        return Math.Sqrt(_x * _x + _y * _y + _z * _z);
    }
}