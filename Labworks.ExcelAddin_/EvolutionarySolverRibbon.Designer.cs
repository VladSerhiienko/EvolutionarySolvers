namespace Labworks.ExcelAddin
{
    partial class EvolutionarySolverRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EvolutionarySolverRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.sheetLW4EditBox = this.Factory.CreateRibbonEditBox();
            this.runFromSheetLW4Button = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Evolutionary Solvers";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.sheetLW4EditBox);
            this.group1.Items.Add(this.runFromSheetLW4Button);
            this.group1.Label = "Labwork 4";
            this.group1.Name = "group1";
            // 
            // sheetLW4EditBox
            // 
            this.sheetLW4EditBox.Label = "Sheet";
            this.sheetLW4EditBox.Name = "sheetLW4EditBox";
            this.sheetLW4EditBox.ScreenTip = "Excel sheet name, where the labwork task can be read from";
            this.sheetLW4EditBox.Text = null;
            // 
            // runFromSheetLW4Button
            // 
            this.runFromSheetLW4Button.Label = "Run from sheet";
            this.runFromSheetLW4Button.Name = "runFromSheetLW4Button";
            this.runFromSheetLW4Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RunFromSheetLW4Button_Click);
            // 
            // group3
            // 
            this.group3.Label = "Labwork 5";
            this.group3.Name = "group3";
            // 
            // group2
            // 
            this.group2.Items.Add(this.label1);
            this.group2.Items.Add(this.label2);
            this.group2.Label = "About";
            this.group2.Name = "group2";
            // 
            // label1
            // 
            this.label1.Label = "Vlad Serhiienko";
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.Label = "vlad.serhiienko@gmail.com";
            this.label2.Name = "label2";
            // 
            // EvolutionarySolverRibbon
            // 
            this.Name = "EvolutionarySolverRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EvolutionarySolverRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox sheetLW4EditBox;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton runFromSheetLW4Button;
    }

    partial class ThisRibbonCollection
    {
        internal EvolutionarySolverRibbon EvolutionarySolverRibbon
        {
            get { return this.GetRibbon<EvolutionarySolverRibbon>(); }
        }
    }
}
