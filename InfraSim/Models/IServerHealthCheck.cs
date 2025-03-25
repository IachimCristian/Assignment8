namespace InfraSim.Models
{
    public interface IServerHealthCheck
    {
        bool IsIdle { get; }
        bool IsNormal { get; }
        bool IsOverloaded { get; }
        bool IsFailed { get; }
    }
} 