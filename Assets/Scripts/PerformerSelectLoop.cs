public class PerformerSelectLoop : Loop {

    private Director director;
    private TaskLoop taskLoop;
    private int captain;
    private int captainDelta = 0;
    private int captainDeltaMax;

    public PerformerSelectLoop(Director directorP, TaskLoop taskLoop) {
        stepLength = 3;
        director = directorP;
        captain = director.captain;
        captainDeltaMax = director.playerCount - 1;
        this.taskLoop = taskLoop;
    }

    public override void ExecuteStep(int step) {
        switch (step) {
            case 0:
                director.AssignPerformer((captain + captainDelta) % director.playerCount);
                this.Execute();
                break;
            case 1:
                director.DiscussPerformer();
                this.Execute();
                break;
            case 2:
                bool pass = director.VoteOnPerformer();
                if (pass) {
                    taskLoop.Execute();
                } else {
                    captainDelta += 1;
                    if (captainDelta > captainDeltaMax) {
                        taskLoop.Execute();
                    } else {
                        this.Execute();
                    }
                }
                break;
            default:
                break;
        }
    }
}
