// See https://aka.ms/new-console-template for more information
using PersonalIncomeTaxComputationLogic.ComputationEngine;
using PersonalIncomeTaxComputationLogic.DTOs;

Console.WriteLine("Hello, World!");


// definde the archType
string archType = "SeniorCitizen";

// definde the Computaion engine
ComputationEngine ce = new ComputationEngine();


// definde DTO to use for the engine // from the user interface 
TaxDTO tdto = new TaxDTO { Id = 1, taxparams = new() };


// add the archType and the data transfer object 'DTO' to the engine
ce.Put(archType, tdto);

// definde and invoke the dispatcher object
var dispatcher = CommandDispatcher.Dispatch(archType, ce);

Console.ReadKey();
