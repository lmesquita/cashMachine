using Microsoft.AspNetCore.Mvc;
using cashMachine.Models;

namespace cashMachine.Controllers;

public class CashMachineController: Controller
{
  [HttpGet]
    public ActionResult Index()
    {
      return View();
    }

    static List<BankNoteViewModel>? bankNotes;

    [HttpPost]
    public ActionResult Index(IndexViewModel indexViewModel)
    {
      ModelState.Clear();
      if (indexViewModel.CashMachine != null)
      {
        bankNotes = new List<BankNoteViewModel>();

        bankNotes.Add(new BankNoteViewModel(200, 0));
        bankNotes.Add(new BankNoteViewModel(100, 0));
        bankNotes.Add(new BankNoteViewModel(50, 0));
        bankNotes.Add(new BankNoteViewModel(20, 0));
        bankNotes.Add(new BankNoteViewModel(10, 0));
        bankNotes.Add(new BankNoteViewModel(5, 0));
        bankNotes.Add(new BankNoteViewModel(2, 0));

          while ((indexViewModel.CashMachine.Num % 5) != 0) {
            indexViewModel.CashMachine.Num -= 2;
            bankNotes[6].Qtt += 1;
          }

          bankNotes.ForEach(delegate(BankNoteViewModel b)
          {
            if ( indexViewModel.CashMachine.Num > 0 ) {
              b.Qtt = indexViewModel.CashMachine.Num / b.Worth;
              indexViewModel.CashMachine.Num -= b.Qtt * b.Worth;
            }
          });

          indexViewModel.CashMachine.Result = bankNotes;
      }

      return View(indexViewModel);
    }
}