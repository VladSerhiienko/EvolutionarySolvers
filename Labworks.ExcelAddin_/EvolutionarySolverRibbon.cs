using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using System.Threading.Tasks;
using Labworks.Framework;

namespace Labworks.ExcelAddin
{
    public partial class EvolutionarySolverRibbon
    {
        private void EvolutionarySolverRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private async void RunFromSheetLW4Button_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var activeSheet = ExcelAddin.Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                activeSheet.Name = "LW4-" + (string)activeSheet.Range["B1"].Value;

                const int cellIndex = 2;
                const string cellName = "B";

                var desc = new TaskLW4Description();
                desc.A = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.B = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.C = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.D = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.XMin = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.XMax = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.TargetType = (string)activeSheet.Range[cellName + cellIndex++].Value;
                desc.CrossoverType = (string)activeSheet.Range[cellName + cellIndex++].Value;
                desc.CrossoverProbability = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.MutateProbability = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.ElitismPercentage = (double)activeSheet.Range[cellName + cellIndex++].Value;
                desc.SelectionType = (string)activeSheet.Range[cellName + cellIndex++].Value;

                await Task.Run(() =>
                    {
                        TargetFunction function = desc.TargetType.ToLower() == "min"
                            ? new TargetFunctionMin(desc.XMin, desc.XMax)
                            : new TargetFunctionMax(desc.XMin, desc.XMax);

                        function.A = desc.A;
                        function.B = desc.B;
                        function.C = desc.C;
                        function.D = desc.D;

                        var solver = new TargetFunctionSolver();
                        solver.ElitismPercentage = desc.ElitismPercentage;
                        solver.MutationProbability = desc.MutateProbability;
                        solver.CrossoverProbability = desc.CrossoverProbability;

                        switch (desc.SelectionType)
                        {
                            case "Tournament": solver.ParentSelection = GAF.ParentSelectionMethod.TournamentSelection; break;
                            case "FitnessProportionate": solver.ParentSelection = GAF.ParentSelectionMethod.FitnessProportionateSelection; break;
                            case "StochasticUniversalSampling": solver.ParentSelection = GAF.ParentSelectionMethod.StochasticUniversalSampling; break;
                        }
                        switch (desc.CrossoverType)
                        {
                            case "DoublePoint": solver.CrossoverType = GAF.Operators.CrossoverType.DoublePoint; break;
                            case "DoublePointOrdered": solver.CrossoverType = GAF.Operators.CrossoverType.DoublePointOrdered; break;
                            case "SinglePoint": solver.CrossoverType = GAF.Operators.CrossoverType.SinglePoint; break;
                        }

                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
