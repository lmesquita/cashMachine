using System.ComponentModel.DataAnnotations;
namespace cashMachine.Models;

public class CashMachineViewModel
{

  [Display(Name = "Valor de saque: R$")]
  public int Num { get; set; }

  [Display(Name = "Quantidade de notas")]
  [DataType(DataType.MultilineText)]
  public List<BankNoteViewModel>? Result { get; set; }

}
