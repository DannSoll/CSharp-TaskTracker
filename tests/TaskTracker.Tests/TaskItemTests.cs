namespace TaskTracker.Tests;

using TaskTracker.App;

public class TaskItemTests
{
    [Fact]
    public void TaskItem_WhenCreated_ShouldKeepAssignedProperties()
    {
        var id = Guid.NewGuid();
        var expectedTitle = "Hello World!";
        var now = DateTime.UtcNow;

        var task = new TaskItem(id, expectedTitle, false, now);

        Assert.Equal(id, task.Id);
        Assert.Equal(expectedTitle, task.Title);
        Assert.False(task.IsCompleted);
        Assert.Equal(now, task.CreatedAt);
    }
}
