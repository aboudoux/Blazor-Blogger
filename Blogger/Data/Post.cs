namespace Blogger.Data;

public record Post(int Id, int UserId, string Title, string Body, bool Hide);
