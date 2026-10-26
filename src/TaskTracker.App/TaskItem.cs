namespace TaskTracker.App;

public record TaskItem(
    Guid Id,
    string Title,
    bool IsCompleted,
    DateTime CreatedAt
);