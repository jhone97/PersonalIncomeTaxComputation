namespace PersonalIncomeTaxComputationLogic.Interfaces;

interface IComputationCommand
{
    bool Execute(ComputationEngine.ComputationEngine ctx);
}
