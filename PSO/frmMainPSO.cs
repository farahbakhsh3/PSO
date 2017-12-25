using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PSO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            combType.SelectedIndex = 0;
        }

        ///////////////////////////        
        clsFitness cFitness = new clsFitness();

        public Stopwatch SW;
        public Random Randd = new Random();
        TreeNode objNode = new TreeNode();
        TreeNode objNode2 = new TreeNode();
        public double[,,] PlotSwarm;
        public double[,] PlotGlobal;

        public PSOType PSO_Type;
        public Particle[] Swarm;
        public Particle GlobalBest;

        public double W;
        public double C1;
        public double C2;
        public double wMira;

        public int SwarmSize;
        public int maxIter;
        public double lb_domXi;
        public double ub_domXi;
        public double lb_SpeedXi;
        public double ub_SpeedXi;
        public int dimSize;
        public int decP;
        public int cFunc = 1;

        public void PSO_Init()
        {
            if (PSO_Type == PSOType.Minimization)
                GlobalBest.BestFitnessValue = double.PositiveInfinity;
            else
                GlobalBest.BestFitnessValue = double.NegativeInfinity;

            for (int i = 0; i < SwarmSize; i++)
            {
                Swarm[i].Position = PSO_Rand(lb_domXi, ub_domXi, dimSize);
                Swarm[i].Speed = PSO_Rand(lb_domXi, ub_domXi, dimSize);
                Swarm[i].FitnessValue = PSO_Round(cFitness.funcFitness(Swarm[i].Position));
                Swarm[i].BestFitnessValue = Swarm[i].FitnessValue;
                Swarm[i].BestPosition = (double[])Swarm[i].Position.Clone();

                if (IsBetter(Swarm[i].BestFitnessValue, GlobalBest.BestFitnessValue, PSO_Type))
                {
                    GlobalBest.BestPosition = (double[])Swarm[i].Position.Clone();
                    GlobalBest.BestFitnessValue = Swarm[i].BestFitnessValue;
                }

                // Plot GlobalBestFitness
                chartGlobalFitness.Series[0].Points.AddXY(0, GlobalBest.BestFitnessValue);
                //Fill PlotSwarm Matrix
                FillPlotSwarmPosition(0, i, Swarm[i].Position);
                //Fill PlotGlobal Matrix
                FillPlotGlobalPosition(0, GlobalBest.BestPosition);
            }
            // Display Results
            DispResult(PSODispType.GlobalBest, "Iter : 0     " + GlobalBest.BestFitnessValue + " ::      " + sResult(GlobalBest.BestPosition));
            for (int i = 0; i < SwarmSize; i++)
            {
                DispResult(PSODispType.Swarm, "Swarm [" + i + "] :      " + Swarm[i].FitnessValue);
                DispResult(PSODispType.SwarmPosition, "Position :          " + sResult(Swarm[i].Position));
                DispResult(PSODispType.SwarmPosition, "Speed :          " + sResult(Swarm[i].Speed));
                DispResult(PSODispType.SwarmPosition, "Best Pos :          " + sResult(Swarm[i].BestPosition));
            }
        }

        public void PSO_Run()
        {
            PSO_Init();
            // Main Loop 
            for (int iter = 1; iter < maxIter; iter++)
            {
                for (int i = 0; i < SwarmSize; i++)
                {
                    for (int j = 0; j < dimSize; j++)
                    {
                        // Update Swarm Speed
                        Swarm[i].Speed[j] = W * Swarm[i].Speed[j]
                            + C1 * PSO_Rand() * (Swarm[i].BestPosition[j] - Swarm[i].Position[j])
                            + C2 * PSO_Rand() * (GlobalBest.BestPosition[j] - Swarm[i].Position[j]);
                        // Bound Speed
                        Swarm[i].Speed[j] = UpdateSwarmSpeed(Swarm[i].Speed[j]);
                        // Update Swarm Position
                        Swarm[i].Position[j] = UpdateSwarmPosition(Swarm[i].Position[j], Swarm[i].Speed[j]);
                    }
                    Swarm[i].FitnessValue = PSO_Round(cFitness.funcFitness(Swarm[i].Position));

                    if (IsBetter(Swarm[i].FitnessValue, Swarm[i].BestFitnessValue, PSO_Type))
                    {
                        Swarm[i].BestPosition = (double[])Swarm[i].Position.Clone();
                        Swarm[i].BestFitnessValue = Swarm[i].FitnessValue;

                        if (IsBetter(Swarm[i].BestFitnessValue, GlobalBest.BestFitnessValue, PSO_Type))
                        {
                            GlobalBest.BestPosition = (double[])Swarm[i].Position.Clone();
                            GlobalBest.BestFitnessValue = Swarm[i].BestFitnessValue;
                        }
                    }

                    //Fill PlotSwarm Matrix
                    FillPlotSwarmPosition(iter, i, Swarm[i].Position);
                    //Fill PlotGlobal Matrix
                    FillPlotGlobalPosition(iter, GlobalBest.BestPosition);
                }
                W *= wMira;

                // Plot GlobalBestFitness
                chartGlobalFitness.Series[0].Points.AddXY(iter, GlobalBest.BestFitnessValue);
                // Display Results
                DispResult(PSODispType.GlobalBest, "Iter :" + iter + "     " + GlobalBest.BestFitnessValue + " ::      " + sResult(GlobalBest.BestPosition));
                for (int i = 0; i < SwarmSize; i++)
                {
                    DispResult(PSODispType.Swarm, "Swarm [" + i + "] :      " + Swarm[i].FitnessValue);
                    DispResult(PSODispType.SwarmPosition, "Position :          " + sResult(Swarm[i].Position));
                    DispResult(PSODispType.SwarmPosition, "Speed :          " + sResult(Swarm[i].Speed));
                    DispResult(PSODispType.SwarmPosition, "Best Pos :          " + sResult(Swarm[i].BestPosition));
                }
            }
        }

        private void btnRunPSO_Click(object sender, System.EventArgs e)
        {
            InitState();
            treeView1.Nodes.Clear();
            SW = new Stopwatch();
            SW.Start();
            PSO_Run();
            lblMiliSecTime.Text = SW.ElapsedMilliseconds + "  MiliSec";
            SW.Stop();

            // Plot Button Enable/Disable
            if ((dimSize == 2))
                btnDispPlot.Enabled = true;
            else
                btnDispPlot.Enabled = false;
        }
        void InitState()
        {
            cFitness.mFunc = combFitnessFunc.SelectedIndex;
            switch (combType.SelectedIndex)
            {
                case 0:
                    PSO_Type = PSOType.Minimization;
                    break;
                case 1:
                    PSO_Type = PSOType.Maximization;
                    break;
            }

            dimSize = Convert.ToInt32(txtdimSize.Text);
            ub_domXi = Convert.ToDouble(txtUBXi.Text);
            lb_domXi = Convert.ToDouble(txtLBXi.Text);
            ub_SpeedXi = Convert.ToDouble(txtUbSpeedXi.Text);
            lb_SpeedXi = Convert.ToDouble(txtLbSpeedXi.Text);
            decP = Convert.ToInt32(txtdecP.Text);
            SwarmSize = Convert.ToInt32(txtSwarmSize.Text);
            maxIter = Convert.ToInt32(txtmaxIter.Text);
            W = Convert.ToDouble(txtW.Text);
            C1 = Convert.ToDouble(txtC1.Text);
            C2 = Convert.ToDouble(txtC2.Text);
            wMira = Convert.ToDouble(txtwMira.Text);

            Swarm = new Particle[SwarmSize];
            PlotSwarm = new double[maxIter, SwarmSize, 2];
            PlotGlobal = new double[maxIter, 2];

            chartGlobalFitness.Series[0].Points.Clear();
        }

        public double PSO_Round(double x)
        {
            if (decP != -1)
                return Math.Round(x, decP);
            else
                return x;
        }

        public double PSO_Rand()
        {
            return PSO_Round(Randd.NextDouble());
        }

        public double PSO_Rand(double a, double b)
        {
            double outRand = (a + (b - a) * PSO_Rand());
            return outRand;
        }

        public double[] PSO_Rand(double a, double b, int n)
        {
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = PSO_Rand(a, b);
            }
            return x;
        }

        public bool IsBetter(double val1, double val2, PSOType Type)
        {
            if (Type == PSOType.Minimization)
                return (val1 <= val2);
            else
                return (val1 >= val2);
        }

        double UpdateSwarmPosition(double Pos, double Speed)
        {
            double OutPos = Pos + Speed;
            OutPos = Math.Max(Math.Min(OutPos, ub_domXi), lb_domXi);
            return OutPos;
        }

        double UpdateSwarmSpeed(double Speed)
        {
            double OutPos = Math.Max(Math.Min(Speed, ub_SpeedXi), lb_SpeedXi);
            return OutPos;
        }

        string sResult(double[] inp)
        {
            int d = inp.Length;
            string strText = "" + PSO_Round(inp[0]);
            for (int i = 1; i < d; i++)
                strText += "     " + PSO_Round(inp[i]);
            return strText;
        }

        void DispResult(PSODispType DispType, string Text)
        {
            switch (DispType)
            {
                case PSODispType.GlobalBest:
                    objNode = treeView1.Nodes.Add(Text);
                    break;
                case PSODispType.Swarm:
                    objNode2 = objNode.Nodes.Add(Text);
                    break;
                case PSODispType.SwarmPosition:
                    objNode2.Nodes.Add(Text);
                    break;
            }
        }

        void FillPlotSwarmPosition(int Iter, int Swarm, double[] Position)
        {
            if (Position.Length == 2)
            {
                PlotSwarm[Iter, Swarm, 0] = PSO_Round(Position[0]);
                PlotSwarm[Iter, Swarm, 1] = PSO_Round(Position[1]);
            }
        }

        void FillPlotGlobalPosition(int Iter, double[] Position)
        {
            if (Position.Length == 2)
            {
                PlotGlobal[Iter, 0] = PSO_Round(Position[0]);
                PlotGlobal[Iter, 1] = PSO_Round(Position[1]);
            }
        }

        private void btnDispPlot_Click(object sender, EventArgs e)
        {
            frmPlotPSO frmPlot = new frmPlotPSO(PlotSwarm, PlotGlobal);
            frmPlot.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            combFitnessFunc.SelectedIndex = 0;
            combType.SelectedIndex = 0;
        }
    }

    public struct Particle
    {
        public double[] Position;
        public double[] Speed;
        public double FitnessValue;
        public double[] BestPosition;
        public double BestFitnessValue;
    }

    public enum PSOType
    {
        Maximization, Minimization
    }

    public enum PSODispType
    {
        Swarm, SwarmPosition, GlobalBest
    }
}
