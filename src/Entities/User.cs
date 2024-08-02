using System.Text.Json.Serialization;

namespace Entities;

public record User
{
    public Guid Id {get;set;}
    public string Nama {get;set;}
    public string RoleName {get;set;}
    public List<Message>? Message {get;set;}
}
