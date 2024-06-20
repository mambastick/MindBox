namespace MindBox.Shapes.Abstractions;

public interface ITriangle : IShape
{
    bool IsRightAngled { get; }
}