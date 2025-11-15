namespace BlueTimelapse.BlueIris;

public record CameraGroup(string name, string value)
{
    public override string ToString() => name;
}