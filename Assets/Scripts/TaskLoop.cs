public class TaskLoop : Loop {

    private Director director;
    private PerformerSelectLoop performerSelectLoop;

    public TaskLoop(Director director) {
        stepLength = 3;
        this.director = director;
    }

    public override void ExecuteStep(int step) {
        switch (step) {
            case 0:
                // 组队
                performerSelectLoop = new PerformerSelectLoop(director, this);
                performerSelectLoop.Execute();
                break;
            case 1:
                // 出任务
                director.PerformTask();
                this.Execute();
                break;
            case 2:
                // 查看结果
                bool needNextTask = director.CheckResult();
                if (needNextTask) {
                    this.Execute();
                }
                break;
            default:
                break;
        }
    }
}
