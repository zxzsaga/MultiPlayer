public class GameLoop : Loop {

    private Director director;
    public TaskLoop taskLoop;

    public GameLoop(Director director) {
        stepLength = 3;
        this.director = director;
    }

    public override void ExecuteStep(int step) {
        switch (step) {
            case 0:
                director.NamePlayer();
                this.Execute();
                break;
            case 1:
                director.AssignRole();
                this.Execute();
                break;
            case 2:
                taskLoop = new TaskLoop(director);
                taskLoop.Execute();
                break;
            default:
                break;
        }
    }
}
