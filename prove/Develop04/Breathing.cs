
namespace Develop4{
class Breathing : Activity{
    
    private int _totalCycles, _cycleLength = 10;     

    // Construtors
    public Breathing() : base() {
        _totalCycles = this.CalculateCycles(base.GetDuration(), _cycleLength);
    }
    public Breathing(int duration) : base(duration){
        _totalCycles = this.CalculateCycles(base.GetDuration(), _cycleLength);
    }
    public Breathing(string message): base(message){
        _totalCycles = this.CalculateCycles(base.GetDuration(), _cycleLength);
    }
    public Breathing(string startMessage, string endMessage) : base(startMessage, endMessage){
        _totalCycles = this.CalculateCycles(base.GetDuration(), _cycleLength);
    }
    public Breathing(int duration, string message) : base(duration, message){
        _totalCycles = this.CalculateCycles(base.GetDuration(), _cycleLength);
    }
    public Breathing(int duration, string startMessage, string endMessage) : base(duration, startMessage, endMessage){
        _totalCycles = this.CalculateCycles(base.GetDuration(), _cycleLength);
    }

    // Private funtions
    private int CalculateCycles(int duration, int cycleLength){
        int cycles, mod, round;
        mod = duration % cycleLength;
        cycles = duration / cycleLength;
        round = cycleLength / 2;
        if(mod >= round){
            cycles++;
        }
        return cycles;
    }

    // Public funtions 

    public string BreathInTimer(int oldValue){
        oldValue--;
        return $"{oldValue}";
    }

}
}