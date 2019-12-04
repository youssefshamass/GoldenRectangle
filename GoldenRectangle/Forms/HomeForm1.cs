using System;
using System.Collections.Generic;
using System.Drawing;
using GoldenRectangle.Core;
using MetroSet_UI.Child;
using MetroSet_UI.Forms;

namespace GoldenRectangle.Forms
{
    public partial class HomeForm1 : MetroSetForm
    {
        #region Constructor

        public HomeForm1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void generateButton_Click(object sender, System.EventArgs e)
        {
            do
            {
                smallBoardsListView.Clear();

                if (!validateBoardGeneration())
                    break;

                int selectedRectangleWidth = int.Parse(rectangleWidthTextBox.Text.Replace("Correction: ", ""));
                selectedRectangleWidth = FibonnaciStore.getInstance().correctNumber(selectedRectangleWidth);
                rectangleWidthTextBox.Text = "Correction: " + selectedRectangleWidth;

                List<int> fibonacciEntries = FibonnaciStore.getInstance().getRespectiveFibonnaciSeries(selectedRectangleWidth);
                if (fibonacciEntries == null || fibonacciEntries.Count == 0)
                {
                    MetroSetMessageBox.Show(this, "No results found, please try another value" + Constants.MAX_NUMBER_ALLOWED);
                    break;
                }

                foreach (int entry in fibonacciEntries)
                {
                    smallBoardsListView.AddItem(entry.ToString());
                }
            } while (false);

        }

        private void addBoxButton_Click(object sender, System.EventArgs e)
        {
            do
            {
                if (!validateBoxSize())
                    break;

                int boxSize = int.Parse(boxSizeTextBox.Text);
                int respectiveFibonnaciNumber = FibonnaciStore.getInstance().correctNumber(boxSize);

                string toAdd = respectiveFibonnaciNumber.ToString();
                
                if (!FibonnaciStore.getInstance().isValidFibonnaciNumber(boxSize))
                    toAdd = "Correction: " + toAdd;

                if (boxSize != 1 && isDuplicateInput(toAdd))
                {
                    MetroSetMessageBox.Show(this, "Already Added");
                    boxSizeTextBox.Text = string.Empty;
                    break;
                }

                inputListBox.AddItem(toAdd);
                boxSizeTextBox.Text = string.Empty;
            } while (false);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputListBox.Clear();
            outputListBox.Clear();
            boxSizeTextBox.Text = string.Empty;
            rectangleSizeTextBox.ReadOnly = false;
            rectangleSizeTextBox.Text = string.Empty;
        }

        private void generateSolutionButton_Click(object sender, EventArgs e)
        {
            List<int> inputList = new List<int>();
            List<int> outputList = null;
            do
            {
                outputListBox.Clear();
                rectangleSizeTextBox.Text = string.Empty;

                if(inputListBox.Items == null || inputListBox.Items.Count == 0)
                {
                    MetroSetMessageBox.Show(this, "Invalid Operation, Empty input list");
                    break;
                }

                int startFrom = 1;
                int target = 0;

                foreach (string entry in inputListBox.Items)
                {
                    int entryRepresentation = int.Parse(entry.Replace("Correction:", ""));

                    //if (entryRepresentation < startFrom)
                    //    startFrom = entryRepresentation;

                    if (target < entryRepresentation)
                        target = entryRepresentation;

                    inputList.Add(entryRepresentation);
                }

                outputList = FibonnaciStore.getInstance().getRespectiveFibonnaciSeries(target, startFrom, true);
                foreach (int entry in outputList)
                {
                    string toAdd = entry.ToString();

                    if (!inputList.Contains(entry))
                        toAdd = "Missing: " + toAdd;

                    outputListBox.AddItem(toAdd);
                }

                int rectangleSize = outputList[outputList.Count - 1];
                if (outputList.Count > 1)
                    rectangleSize += outputList[outputList.Count - 2];

                rectangleSizeTextBox.Text = rectangleSize.ToString();
                rectangleSizeTextBox.ReadOnly = true;
            } while (false);
        }
        #endregion

        #region Private members

        private bool validateBoardGeneration()
        {
            if (string.IsNullOrEmpty(rectangleWidthTextBox.Text))
            {
                MetroSetMessageBox.Show(this, "Rectangle width is required");
                return false;
            }

            int selectedRectangleWidth = 0;
            if (!int.TryParse(rectangleWidthTextBox.Text.Replace("Correction: ", ""), out selectedRectangleWidth))
            {
                MetroSetMessageBox.Show(this, "Invalid format, number is required");
                return false;
            }

            if (selectedRectangleWidth <= 0 || selectedRectangleWidth > Constants.MAX_NUMBER_ALLOWED)
            {
                MetroSetMessageBox.Show(this, "Please, enter a valid number that is smaller than " + Constants.MAX_NUMBER_ALLOWED);
                return false;
            }

            return true;
        }

        private bool validateBoxSize()
        {
            if (string.IsNullOrEmpty(boxSizeTextBox.Text))
            {
                MetroSetMessageBox.Show(this, "Box Size is required");
                return false;
            }

            int boxSize = 0;
            if (!int.TryParse(boxSizeTextBox.Text, out boxSize))
            {
                MetroSetMessageBox.Show(this, "Invalid format, number is required");
                return false;
            }

            if (boxSize <= 0 || boxSize > Constants.MAX_NUMBER_ALLOWED)
            {
                MetroSetMessageBox.Show(this, "Please, enter a valid number that is smaller than " + Constants.MAX_NUMBER_ALLOWED);
                return false;
            }

            return true;
        }

        private bool isDuplicateInput(string toAdd)
        {
            if (inputListBox.Items == null || inputListBox.Items.Count == 0)
                return false;

            return inputListBox.Items.Contains(toAdd);
        }

        #endregion
    }
}
