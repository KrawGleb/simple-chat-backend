using iLearning.SimpleChat.Domain.Entities.Interfaces;

namespace iLearning.SimpleChat.Domain.Entities;

public class User : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
