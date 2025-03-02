using PersonalIncomeTaxComputationLogic.DTOs;
using PersonalIncomeTaxComputationLogic.Interfaces;

namespace PersonalIncomeTaxComputationLogic.SystemCommands;

class OrdinaryCitizenCommands : IComputationCommand
{

    public bool Execute(ComputationEngine.ComputationEngine ctx)
    {
         TaxDTO td = (TaxDTO)ctx.Get("tax_cargo");

        // manual calcuation

        td.taxparams.TaxLiability = 1500;
        td.taxparams.Computed = true;
        return true;
    }
}
