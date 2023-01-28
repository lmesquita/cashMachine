namespace cashMachine.Models;

public class BankNoteViewModel
{
 public BankNoteViewModel() {}

 public int Worth { get; set; }
 public int Qtt { get; set; }

  public BankNoteViewModel(int worth, int qtt)
  {
    this.Worth = worth;
    this.Qtt = qtt;
  }

}