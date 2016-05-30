public class Loop {

    public int step = 0;
    public int stepLength;
    public bool isLoopEnd = false;

    public Loop() {}

    public Loop(int stepLength) {
        this.stepLength = stepLength;
    }

    public void Execute() {
        if (isLoopEnd) {
            return;
        }
        ExecuteStep(step);
        step = (step + 1) % stepLength;
    }

    public virtual void ExecuteStep(int step) {
        switch (step) {
            default:
                break;
        }
    }
}
