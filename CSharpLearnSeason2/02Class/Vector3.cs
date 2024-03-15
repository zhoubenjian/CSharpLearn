namespace _02Class;

public class Vector3
{
    private float x;
    private float y;
    private float z;


    public float X
    {
        get => x;
        set => x = value;
    }

    public float Y
    {
        get => y;
        set => y = value;
    }

    public float Z
    {
        get => z;
        set => z = value;
    }


    public double Distance()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }
}