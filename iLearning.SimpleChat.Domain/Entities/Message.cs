using iLearning.SimpleChat.Domain.Entities.Interfaces;

namespace iLearning.SimpleChat.Domain.Entities;

public class Message : IEntity
{
    public int Id { get; set; }
    public int FromId { get; set; }
    public User From { get; set; }
    public int ToId { get; set; }
    public User To { get; set; }
    public string Content { get; set; }
}
