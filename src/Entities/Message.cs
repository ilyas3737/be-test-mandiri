using System.Text.Json.Serialization;

namespace Entities;

public record Message
{
    public Guid Id {get;set;}
    public Guid UserId {get;set;}
    public string Content {get;set;}
    public bool ReadStatus {get;set;}
    public DateTime? CreatedDate {get;set;}
    public User? User {get;set;}
}
