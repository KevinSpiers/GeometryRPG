using UnityEngine;
using System.Collections;

public class MenuManager{
    int[,] buttonGrid; //value of 1 means there is a button there, 0 means no button

    int selectedRow;
    int selectedColumn;

    int rows;
    int columns;

    public MenuManager(int rows, int columns){
        buttonGrid = new int[rows, columns];
        selectedColumn = 0;
        selectedRow = 0;
        this.rows = rows;
        this.columns = columns;
        InitializeGrid();
    }

    private void InitializeGrid()
    {
        for(int i=0; i < rows; i++)
        {
            for(int j=0; j < columns; j++)
            {
                buttonGrid[i, j] = 0;
            }
        }
    }
    public void SetButton(int row, int column)
    {
        buttonGrid[row, column] = 1;
    }

    public void SelectCurrent()
    {
        //find the action associated with the currently selected menu option
    }
    public void MoveSelectorLeft()
    {
        int newCol = (selectedColumn - 1) % columns;
        if(buttonGrid[selectedRow, newCol] == 1)
        {
            selectedColumn = newCol;
        }
    }
    public void MoveSelectorRight()
    {
        int newCol = (selectedColumn + 1) % columns;
        if (buttonGrid[selectedRow, newCol] == 1)
        {
            selectedColumn = newCol;
        }
    }
    public void MoveSelectorUp()
    {
        int newRow = (selectedRow - 1) % rows;
        if (buttonGrid[newRow, selectedColumn] == 1)
        {
            selectedRow = newRow;
        }
    }
    public void MoveSelectorDown()
    {
        int newRow = (selectedRow + 1) % rows;
        if (buttonGrid[newRow, selectedColumn] == 1)
        {
            selectedRow = newRow;
        }
    }
}

