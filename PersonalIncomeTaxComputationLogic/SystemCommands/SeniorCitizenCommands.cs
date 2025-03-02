using PersonalIncomeTaxComputationLogic.DTOs;
using PersonalIncomeTaxComputationLogic.Interfaces;

namespace PersonalIncomeTaxComputationLogic.Cases;

public class SeniorCitizenCommands : IComputationCommand
{
    // err throw
    public bool Execute(ComputationEngine.ComputationEngine ctx)
    {
        // what is the Get("tax_cargo") do and where it came from 
        TaxDTO td = (TaxDTO)ctx.Get("tax_cargo");
        /*
            do computation logic herr
        */

        td.taxparams.TaxLiability = 1000;
        td.taxparams.Computed = true;
        return true;    
    }
}
