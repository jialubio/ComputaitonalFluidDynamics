using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Parabolic_New
{

    public partial class Parabolic : Form
    {

        #region fields
        private int iNumberOfPoints         = new int();
        private int iNumberOfSteps          = new int();
        private int iStepCounter            = new int();
        private double dBeta                = new double();
        private double dLength              = new double();
        private double dLeftBC              = new double();
        private double dRightBC             = new double();
        private double dDiffusionNumber     = new double();
        private double dDiffusionConstant   = new double();
        private double dTimeStepSize        = new double();
        private double dSpaceStepSize       = new double();
        private double dInitialCondition    = new double();
        private ArrayList alOldOldSolution  = new ArrayList();
        private ArrayList alOldSolution     = new ArrayList();
        private ArrayList alNewSolution     = new ArrayList();
        private ArrayList alSpacePoints     = new ArrayList();
        #endregion

        public Parabolic ( )
        {

            InitializeComponent ( );

            dBeta = 0.5d;
            dLength = 0.0d;
            dLeftBC = 1.0d;
            dRightBC = 1.0d;
            iStepCounter = 0;
            radioButton1.Checked = true;

        }

        private void buttonReset_Click ( object sender , System.EventArgs e )
        {

            dLength = 1.0f;
            dLeftBC = 1.0f;
            dRightBC = 0.0f;
            iStepCounter = 0;

            // get the independant parameters
            iNumberOfPoints = int.Parse ( textBoxNumberOfPoints.Text );
            iNumberOfSteps = int.Parse ( textBoxNumberOfSteps.Text );
            dTimeStepSize = double.Parse ( textBoxTimeStepSize.Text );
            dDiffusionConstant = double.Parse ( textBoxDiffusionConstant.Text );

            // set the derived parameters
            dSpaceStepSize = dLength / ( double ) ( iNumberOfPoints - 1 );
            dTimeStepSize = 0.1 / ( double ) iNumberOfSteps;
            dDiffusionNumber = dDiffusionConstant * dTimeStepSize / Math.Pow ( dSpaceStepSize , 2.0d );

            // display the derived derived
            textBoxDiffusionNumber.Text = dDiffusionNumber.ToString ( );
            textBoxSpaceStepSize.Text = dSpaceStepSize.ToString ( );
            textBoxTimeStepSize.Text = dTimeStepSize.ToString ( );
            labelStepCount.Text = " ";

            alNewSolution.Clear ( );
            alOldSolution.Clear ( );
            alOldOldSolution.Clear ( );
            alSpacePoints.Clear ( );

            SetInitialCondition ( );
            GraphSolution ( );

            buttonStepSolution.Enabled = true;
            buttonRun.Enabled = true;

        }

        private void SetInitialCondition ( )
        {
            iStepCounter = 0;

            alNewSolution.Clear ( );
            alOldSolution.Clear ( );
            alOldOldSolution.Clear ( );
            alSpacePoints.Clear ( );

            alNewSolution.Add ( dLeftBC );
            alOldSolution.Add ( dLeftBC );
            alOldOldSolution.Add ( dLeftBC );
            alSpacePoints.Add ( 0.0d );

            for ( int i = 1 ; i < iNumberOfPoints - 1 ; i++ )
            {
                alNewSolution.Add ( dInitialCondition );
                alOldSolution.Add ( dInitialCondition );
                alOldOldSolution.Add ( dInitialCondition );
                alSpacePoints.Add ( ( double ) i * dSpaceStepSize );
            }
            alNewSolution.Add ( dRightBC );
            alOldSolution.Add ( dRightBC );
            alOldOldSolution.Add ( dRightBC );
            alSpacePoints.Add ( dLength );
        }

        private void CopySolution ( )
        {
            alOldOldSolution.Clear ( );
            foreach ( double d in alOldSolution )
            {
                alOldOldSolution.Add ( d );
            }

            alOldSolution.Clear ( );
            foreach ( double d in alNewSolution )
            {
                alOldSolution.Add ( d );
            }

        }

        private void CopyInitialSolution ( )
        {
            alOldOldSolution.Clear ( );
            alOldSolution.Clear ( );
            foreach ( double d in alNewSolution )
            {
                alOldSolution.Add ( d );
                alOldOldSolution.Add ( d );
            }

        }

        private void GraphSolution ( )
        {

            this.chartSolution.Series [ "Solution" ].Points.Clear ( );

            double[] xpoints = new double[alSpacePoints.Count];
            double[] ypoints = new double[alNewSolution.Count];

            for ( int i = 0 ; i < alSpacePoints.Count ; i++ )
            {

                xpoints [ i ] = ( double ) alSpacePoints [ i ];
                ypoints [ i ] = ( double ) alNewSolution [ i ];

                ypoints [ i ] = Math.Min ( ypoints [ i ] , 1.0e12 );
                ypoints [ i ] = Math.Max ( ypoints [ i ] , -1.0e12 );

                this.chartSolution.Series [ "Solution" ].Points.AddXY ( xpoints [ i ] , ypoints [ i ] );

            }

            labelStepCount.Text = string.Format ( "Step count = {0}" , iStepCounter );
            labelStepCount.Update ( );

            Application.DoEvents ( );

        }

        private void EulerStep ( )
        {
            for ( int i = 1 ; i < iNumberOfPoints - 1 ; i++ )
            {
                alNewSolution [ i ] = ( double ) alOldSolution [ i ]
                    + dDiffusionNumber * ( ( double ) alOldSolution [ i + 1 ]
                    - 2.0 * ( double ) alOldSolution [ i ]
                    + ( double ) alOldSolution [ i - 1 ] );
            }
        }

        private void RichardsonStep ( )
        {
            for ( int i = 1 ; i < iNumberOfPoints - 1 ; i++ )
            {
                alNewSolution [ i ] = ( double ) alOldOldSolution [ i ]
                    + 2.0 * dDiffusionNumber * ( ( double ) alOldSolution [ i + 1 ]
                    - 2.0 * ( double ) alOldSolution [ i ]
                    + ( double ) alOldSolution [ i - 1 ] );
            }
        }

        private void DufortFrankelStep ( )
        {
            for ( int i = 1 ; i < iNumberOfPoints - 1 ; i++ )
            {
                alNewSolution [ i ] = ( ( 1.0d - 2.0d * dDiffusionNumber ) * ( double ) alOldOldSolution [ i ]
                    + 2.0d * dDiffusionNumber * ( ( double ) alOldSolution [ i + 1 ] + ( double ) alOldSolution [ i - 1 ] ) )
                    / ( 1.0d + 2.0d * dDiffusionNumber );
            }
        }

        private void LaasonenStep ( )
        {
            int n = new int();
            n = alNewSolution.Count - 2;
            double[] a = new double[n]; // subdiagonal
            double[] b = new double[n]; // diagonal
            double[] c = new double[n]; // superdiagonal
            double[] r = new double[n]; // right hand side vector
            double[] u = new double[n]; // solution vector

            for ( int i = 0 ; i < n ; i++ )
            {
                a [ i ] = -dDiffusionNumber;
                b [ i ] = 1.0d + 2.0d * dDiffusionNumber;
                c [ i ] = -dDiffusionNumber;
                r [ i ] = ( double ) alOldSolution [ i + 1 ];
                u [ i ] = 0.0d;
            }

            // set boundary conditions here
            r [ 0 ] += dDiffusionNumber * dLeftBC;
            r [ n - 1 ] += dDiffusionNumber * dRightBC;

            TridagonalSolver ( a , b , c , r , u );

            for ( int i = 0 ; i < n ; i++ )
            {
                alNewSolution [ i + 1 ] = u [ i ];
            }

        }

        private void CrankNicolsonStep ( )
        {
            int n = new int();
            n = alNewSolution.Count - 2;
            double[] a = new double[n]; // subdiagonal
            double[] b = new double[n]; // diagonal
            double[] c = new double[n]; // superdiagonal
            double[] r = new double[n]; // right hand side vector
            double[] u = new double[n]; // solution vector

            for ( int i = 0 ; i < n ; i++ )
            {
                a [ i ] = -0.5d * dDiffusionNumber;
                b [ i ] = 1.0d + dDiffusionNumber;
                c [ i ] = -0.5d * dDiffusionNumber;
                r [ i ] = 0.5d * dDiffusionNumber * ( double ) alOldSolution [ i + 2 ]
                  + ( 1.0d - dDiffusionNumber ) * ( double ) alOldSolution [ i + 1 ]
                      + 0.5d * dDiffusionNumber * ( double ) alOldSolution [ i ];
                u [ i ] = 0.0d;
            }

            // set boundary conditions here
            r [ 0 ] += 0.5d * dDiffusionNumber * dLeftBC;
            r [ n - 1 ] += 0.5d * dDiffusionNumber * dRightBC;

            TridagonalSolver ( a , b , c , r , u );

            for ( int i = 0 ; i < n ; i++ )
            {
                alNewSolution [ i + 1 ] = u [ i ];
            }
        }

        private void BetaStep ( )
        {
            // set beta
            dBeta = double.Parse ( textBoxBeta.Text );
            if ( dBeta > 1.0d )
            {
                dBeta = 1.0d;
                textBoxBeta.Text = dBeta.ToString ( );
                textBoxBeta.Update ( );
            }
            if ( dBeta < 0.0d )
            {
                dBeta = 0.0d;
                textBoxBeta.Text = dBeta.ToString ( );
                textBoxBeta.Update ( );
            }

            int n = new int();
            n = alNewSolution.Count - 2;
            double[] a = new double[n]; // subdiagonal
            double[] b = new double[n]; // diagonal
            double[] c = new double[n]; // superdiagonal
            double[] r = new double[n]; // right hand side vector
            double[] u = new double[n]; // solution vector

            for ( int i = 0 ; i < n ; i++ )
            {
                a [ i ] = -dBeta * dDiffusionNumber;
                b [ i ] = 1.0d + 2.0d * dBeta * dDiffusionNumber;
                c [ i ] = -dBeta * dDiffusionNumber;
                r [ i ] = ( 1.0d - dBeta ) * dDiffusionNumber * ( double ) alOldSolution [ i + 2 ]
                    + ( 1.0d - 2.0d * ( 1.0d - dBeta ) * dDiffusionNumber ) * ( double ) alOldSolution [ i + 1 ]
                                  + ( 1.0d - dBeta ) * dDiffusionNumber * ( double ) alOldSolution [ i ];
                u [ i ] = 0.0d;
            }

            // set boundary conditions here
            r [ 0 ] += dBeta * dDiffusionNumber * dLeftBC;
            r [ n - 1 ] += dBeta * dDiffusionNumber * dRightBC;

            TridagonalSolver ( a , b , c , r , u );

            for ( int i = 0 ; i < n ; i++ )
            {
                alNewSolution [ i + 1 ] = u [ i ];
            }

        }

        private void buttonStepSolution_Click ( object sender , System.EventArgs e )
        {
            iStepCounter++;

            if ( radioButton1.Checked )
                EulerStep ( );
            else if ( radioButton2.Checked )
                RichardsonStep ( );
            else if ( radioButton3.Checked )
                DufortFrankelStep ( );
            else if ( radioButton4.Checked )
                LaasonenStep ( );
            else if ( radioButton5.Checked )
                CrankNicolsonStep ( );
            else if ( radioButton6.Checked )
                BetaStep ( );
            else
                MessageBox.Show ( "Error: Unknown state in buttonStepSolution_Click" );

            CopySolution ( );
            GraphSolution ( );

        }

        private void buttonRun_Click ( object sender , System.EventArgs e )
        {
            while ( iStepCounter < iNumberOfSteps )
            {
                buttonStepSolution_Click ( null , null );
            }
        }

        private void TridagonalSolver ( double [ ] a , double [ ] b , double [ ] c , double [ ] r , double [ ] u )
        {
            int n = a.Length;
            double[] gam = new double[n];

            if ( b [ 0 ] == 0.0d )
            {
                MessageBox.Show ( "Error 1 in TridagonalSolver" );
                return;
            }
            double bet = b[0];
            u [ 0 ] = r [ 0 ] / b [ 0 ];
            for ( int j = 1 ; j < n ; j++ )
            {
                gam [ j ] = c [ j - 1 ] / bet;
                bet = b [ j ] - a [ j ] * gam [ j ];
                if ( bet == 0.0 )
                {
                    MessageBox.Show ( "Error 2 in TridagonalSolver" );
                    return;
                }
                u [ j ] = ( r [ j ] - a [ j ] * u [ j - 1 ] ) / bet;
            }
            for ( int j = ( n - 2 ) ; j >= 0 ; j-- )
                u [ j ] -= gam [ j + 1 ] * u [ j + 1 ];
        }

        private void radioButton1_CheckedChanged ( object sender , System.EventArgs e )
        {
            HideBeta ( );
        }

        private void radioButton2_CheckedChanged ( object sender , System.EventArgs e )
        {
            HideBeta ( );
        }

        private void radioButton3_CheckedChanged ( object sender , System.EventArgs e )
        {
            HideBeta ( );
        }

        private void radioButton4_CheckedChanged ( object sender , System.EventArgs e )
        {
            HideBeta ( );
        }

        private void radioButton5_CheckedChanged ( object sender , System.EventArgs e )
        {
            HideBeta ( );
        }

        private void radioButton6_CheckedChanged ( object sender , System.EventArgs e )
        {
            ShowBeta ( );
        }

        private void ShowBeta ( )
        {
            textBoxBeta.Show ( );
            label7.Show ( );
            dBeta = double.Parse ( textBoxBeta.Text );
        }

        private void HideBeta ( )
        {
            textBoxBeta.Hide ( );
            label7.Hide ( );
        }

        private void TextBoxTimeStepSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNumberOfPoints_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
