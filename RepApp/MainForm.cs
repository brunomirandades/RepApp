using RepApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(CircuitType));
            typeComboBox.SelectedIndex = 0;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ShowTotalReps();
        }

        private void CheckInputFields()
        {
            if (rangeTextBox.Text == string.Empty)
            {
                throw new ApplicationException("The reps box should not be empty.");
            }

            if (!(Convert.ToInt32(rangeTextBox.Text) >= 1 && Convert.ToInt32(rangeTextBox.Text) < 100))
            {
                throw new ApplicationException("Please insert a number of reps between 1 and 99.");
            }
        }

        private void ShowTotalReps()
        {

            try
            {
                CheckInputFields();
                int reps = Convert.ToInt32(rangeTextBox.Text);
                string circuit = typeComboBox.SelectedItem.ToString();
                int[] totals = CalculateTotalReps(reps, typeComboBox.SelectedItem);
                outputListBox.Items.Add($"Type: {circuit}; Range: {reps}; Total reps: {totals[0]}; Total sets: {totals[1]}");
                //outputListBox.Items.Add($"Total is {totalReps} reps for a {circuit} circuit with range of {reps}.");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please use integers only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int[] CalculateTotalReps(int reps, object type)
        {
            switch (type)
            {
                case CircuitType.Ladder:
                    return Calculations.CalculateLadder(reps);
                case CircuitType.Pyramid:
                    return Calculations.CalculatePyramid(reps);
                case CircuitType.M:
                    return Calculations.CalculateM(reps);
                case CircuitType.V:
                    return Calculations.CalculateV(reps);
                case CircuitType.W:
                    return Calculations.CalculateW(reps);
                default:
                    return null;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }
    }
}
